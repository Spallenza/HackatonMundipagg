using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dlp.Connectors;
using Hackaton.Core.Utility;
using Dlp.Framework.Container;

namespace Hackaton.Core.Repository {
    public class TestRepository : ITestRepository {

        private IConfigurationUtility utility;

        private const string GET_MERCHANTORDERID_QUERY =
            @"SELECT MerchantOrderId FROM CreditCardTransaction 
             INNER JOIN Merchant ON Merchant.MerchantId = MerchantOrder.MerchantId
             WHERE 
             MerchantKey = merchantKey
             AND CrediCardTransactionKey = @CreditCardTransactionKey";

        public TestRepository() {
            utility = IocFactory.Resolve<IConfigurationUtility>();

        }

        /// <summary>
        /// Obtém o merchantOrderId a partir de uma TransactionKey.
        /// </summary>
        /// <param name="creditCardTransactionKey"></param>
        /// <returns></returns>
        public long GetMerchantOrderId(Guid creditCardTransactionKey, Guid merchantKey) {

            long merchantOrderId = 0;
            using (DatabaseConnector dbConnector = new DatabaseConnector(utility.ConnectionString)) {
                
                dbConnector.ExecuteReader<long>(GET_MERCHANTORDERID_QUERY, new {
                    CreditCardTransactionKey = creditCardTransactionKey,
                    MerchantKey = merchantKey
                });
            }

            return merchantOrderId;
        }

        public void GetCreditCardTransactionData(long merchantOrderId) {
            throw new NotImplementedException();
        }
    }
}
