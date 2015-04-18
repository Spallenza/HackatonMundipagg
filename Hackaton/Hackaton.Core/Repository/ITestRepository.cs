using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Core.Repository {
    public interface ITestRepository {


        long GetMerchantOrderId(long merchantOrderId);

        void GetCreditCardTransactionData(long merchantOrderId);

    }
}
