using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrokerRPC.Models
{
    public class Worker
    {
        public string WorkerID { get; private set; }
        public string Address { get; private set; }

        public  GrpcChannel Channel { get; private set; }


        public Worker(string id, string address)
        {
            Channel = GrpcChannel.ForAddress(address);
            Address = address;
            WorkerID = id;
        }
    }
}
