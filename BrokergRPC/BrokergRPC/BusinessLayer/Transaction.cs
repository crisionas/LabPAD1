using BusinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Transaction
    {
        public string owner_card_id { get; set; }
        public string recipient_card_id { get; set; }
        public int transaction_summ { get; set; }
        public string ccy { get; set; }
        public string aditional_comment { get; set; }
        public TypeTransaction transactionType { get; set; }
    }
}
