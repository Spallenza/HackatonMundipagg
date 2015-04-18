using Hackaton.Core.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Core.Repository {
    public interface ITestRepository {


        long GetMerchantOrderId(Guid creditCardTransactionKey, Guid merchantKey);

        List<CreditCardTransactionData> GetCreditCardTransactionData(long merchantOrderId);

    }
}
