using BrokerRPC.Interfaces;
using BrokerRPC.Models;
using BusinessLayer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BrokerRPC.Services
{
    public class BackgroundTaskHandler : IHostedService
    {
        private readonly IMessageStorage _messageStorage;
        private readonly IWorkerConnection _workerStorage;
        private Timer _timer;
        public  BackgroundTaskHandler(IServiceProvider services)
        {
            _messageStorage = services.GetRequiredService<IMessageStorage>();
            _workerStorage = services.GetRequiredService<IWorkerConnection>();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(PrepareTasks, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        private void PrepareTasks(object state)
        {
            var r = new Random();
            var workers = _workerStorage.GetWorkers();
            var total_message = _messageStorage.Count();
            if (workers.Count() != 0 && total_message !=0
                || workers.Count()!=0)
            {
                Task[] taskArray = new Task[total_message];
                for (int i = 0; i < total_message; i++)
                {
                    var data = _messageStorage.GetTransaction();
                    Console.WriteLine("Selected transaction:" + data.aditional_comment);
                    var worker = workers.ElementAt(r.Next(0, workers.Count()));
                    taskArray[i] = Task.Factory.StartNew(() => Send(data, worker));
                }

                Task.WaitAll();
            }
        }

        private void Send(Transaction data, Worker worker)
        {
            var message = new TransactionMessage();

            message.OwnerCardId = data.owner_card_id;
            message.Ccy = data.ccy;
            message.TransactionType = (BrokerRPC.TypeTransaction)data.transactionType;
            message.RecipientCardId = data.recipient_card_id;
            message.AditionalComment = data.aditional_comment;
            message.TransactionSumm = data.transaction_summ;

            var client =new ExecuteTransaction.ExecuteTransactionClient(worker.Channel);
            try
            {
                var response = client.PublicTransaction(message);
                Console.WriteLine("Succeseful send task to Worker:" + worker.Address+
                    "Task number:" +message.AditionalComment);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error while sendind message to Worker:" + worker.Address);
                _workerStorage.ExcludeConnection(worker);
                _messageStorage.Add(data);
            }
            
        }

    }
}
