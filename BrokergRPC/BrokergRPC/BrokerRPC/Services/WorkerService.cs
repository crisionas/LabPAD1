using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrokerRPC;
using BrokerRPC.Interfaces;
using BrokerRPC.Models;
using Grpc.Core;

namespace BrokerRPC.Services
{
    public class WorkerService : WorkerRegistration.WorkerRegistrationBase
    {
        private readonly IWorkerConnection _workerStorage;
        public WorkerService(IWorkerConnection workerConnection)
        {
            _workerStorage = workerConnection;
        }

        public override Task<ConfirmationResponse> RegisterWorker(WorkerMessage request, ServerCallContext context)
        {
            try
            {
                var worker = new Worker(request.WorkerId, request.WorkerAdress);
                var status = _workerStorage.AddConnection(worker);

                if (status)
                {

                    Console.WriteLine("Succesefull registered to BrokerStorage///" + request.WorkerId
                        + "///" + request.WorkerAdress);
                    return Task.FromResult(new ConfirmationResponse()
                    {
                        Message = "Succesefull",
                        Status = true
                    });
                }
                else
                {
                    return Task.FromResult(new ConfirmationResponse()
                    {
                        Message = "Diened acces",
                        Status = false
                    });
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Unable to regiser Worker" + e.Message);
                return Task.FromResult(new ConfirmationResponse()
                {
                    Message = "Diened acces",
                    Status = false
                });
            }
        }
    }
}
