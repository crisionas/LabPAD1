using BrokerRPC.Interfaces;
using BusinessLayer;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BrokerRPC.Services
{
    public class TransactionService: ExecuteTransaction.ExecuteTransactionBase
    {
        private readonly IMessageStorage _storage;
        public TransactionService(IMessageStorage messageStorage)
        {
            _storage = messageStorage;
        }


        public override Task<TransactionResponse> PublicTransaction(TransactionMessage message, ServerCallContext context)
        {
            var transaction = new Transaction();
            transaction.owner_card_id = message.OwnerCardId;
            transaction.ccy = message.Ccy;
            transaction.transactionType = (BusinessLayer.Enums.TypeTransaction)message.TransactionType;
            transaction.recipient_card_id = message.RecipientCardId;
            transaction.aditional_comment = message.AditionalComment;
            transaction.transaction_summ = message.TransactionSumm;

            _storage.Add(transaction);


            return Task.FromResult(
                new TransactionResponse()
                {Status = true, Message ="Succesefull implemented" });
        }
    }
}
