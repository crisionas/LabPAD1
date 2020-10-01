using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrokerRPC.Interfaces
{
   public interface IMessageStorage
    {
        public void Add(Transaction transaction);
        public Transaction GetTransaction();
        public int Count();
    }
}
