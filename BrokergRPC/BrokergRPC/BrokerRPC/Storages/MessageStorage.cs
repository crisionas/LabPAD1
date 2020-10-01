using BrokerRPC.Interfaces;
using BusinessLayer;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrokerRPC.Storages
{
    public class MessageStorage : IMessageStorage
    {

        private readonly  ConcurrentQueue<Transaction> _transactions;

        public MessageStorage()
        {
            _transactions = new ConcurrentQueue<Transaction>();
        }

        public void Add(Transaction transaction)
        {
            _transactions.Enqueue(transaction);
        }

        public int Count()
        {
            return _transactions.Count();
        }

        public Transaction GetTransaction()
        {
            Transaction transaction = new Transaction(); 
            bool status = false;
            while(!status)
            {
                status = _transactions.TryDequeue(out transaction);
            }

            return transaction;

        }
        

    }
}
