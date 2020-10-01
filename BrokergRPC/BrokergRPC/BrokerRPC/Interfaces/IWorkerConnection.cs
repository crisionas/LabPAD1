using BrokerRPC.Models;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrokerRPC.Interfaces
{
    public interface IWorkerConnection
    {
        public IEnumerable<Worker> GetWorkers();
        public bool AddConnection(Worker worker);
        public void ExcludeConnection(Worker worker);
    }
}
