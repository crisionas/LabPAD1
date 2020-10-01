using BrokerRPC.Interfaces;
using BrokerRPC.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrokerRPC.Storages
{
    public class WorkerConnectionStorage : IWorkerConnection
    {

        private ConcurrentDictionary<string,Worker> _workers;

        public WorkerConnectionStorage()
        {
            _workers = new ConcurrentDictionary<string, Worker>();
        }

        public bool AddConnection(Worker worker)
        {

            return _workers.TryAdd(worker.Address,worker);
        }

        public void ExcludeConnection(Worker worker)
        {
            Worker discard;
            _workers.TryRemove(worker.Address, out discard);
        }

        public IEnumerable<Worker> GetWorkers()
        {
            return _workers.Select(m => m.Value).ToList();
        }
    }
}
