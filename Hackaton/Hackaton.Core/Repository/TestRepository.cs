using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dlp.Connectors;
using Hackaton.Core.Utility;
using Dlp.Framework.Container;
using Hackaton.Core.Repository.Entity;

namespace Hackaton.Core.Repository {
    public class TestRepository : ITestRepository {

        private IConfigurationUtility utility;

        private const string GET_MERCHANTORDERID_QUERY =
            @"SELECT MerchantOrder.MerchantOrderId FROM CreditCardTransaction 
            INNER JOIN MerchantOrder ON MerchantOrder.MerchantOrderId = CreditCardTransaction.MerchantOrderId
            INNER JOIN Merchant ON Merchant.MerchantId = MerchantOrder.MerchantId
            WHERE 
            MerchantKey = @merchantKey
            AND CreditCardTransactionKey = @CreditCardTransactionKey";


        private const string GET_CREDITCARDTRANSACTIONDATA_QUERY =
            @"SELECT
            CreditCardTransactionKey as TransactionKey, CreditCardTransactionStatusEnum, InstantBuyKey, TransactionReference,
            UniqueSequentialNumber, AmountInCents, AuthorizedAmountInCents, CapturedAmountInCents 
            VoidedInCents, RefundedAmountInCents, CreditCardOperationEnum, InstallmentCount, CreditCardOperationEnum
            FROM CreditCardTransaction
            INNER JOIN CreditCard ON CreditCard.CreditCardId = CreditCardTransaction.CreditCardId
            WHERE
            MerchantOrderId = @MerchantOrderId";

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
                
              merchantOrderId = Convert.ToInt64(dbConnector.ExecuteReader<long>(GET_MERCHANTORDERID_QUERY, new {
                    CreditCardTransactionKey = creditCardTransactionKey,
                    MerchantKey = merchantKey
                }).FirstOrDefault());
            }

            return merchantOrderId;
        }

        /// <summary>
        /// Obtém uma coleção de CreditCardTransactionData a partir de um merchantOrderId
        /// </summary>
        /// <param name="merchantOrderId"></param>
        public List<CreditCardTransactionData> GetCreditCardTransactionData(long merchantOrderId) {

            List<CreditCardTransactionData> creditCardTransactionDataCollection = new List<CreditCardTransactionData>();

            using (DatabaseConnector dbConnector = new DatabaseConnector(utility.ConnectionString)) {

              creditCardTransactionDataCollection =  dbConnector.ExecuteReader<CreditCardTransactionData>(GET_CREDITCARDTRANSACTIONDATA_QUERY, new {
                    MerchantOrderId = merchantOrderId
                    
                }).ToList();
            }

            return creditCardTransactionDataCollection;
        }
    }
}
