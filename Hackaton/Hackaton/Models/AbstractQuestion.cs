using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Models {
    public abstract class  AbstractQuestion {
        public string CreditCardTransactionResultCount { get; set; }
        public string AcquirerName { get; set; }
        public string TransactionKey { get; set; }
        public string CreditCardTransactionStatusEnum { get; set; }
        public string Success { get; set; }
        public string InstantBuyKey { get; set; }
        public string UniqueSequentialNumber { get; set; }
        public string AmountInCents { get; set; }
    }
}