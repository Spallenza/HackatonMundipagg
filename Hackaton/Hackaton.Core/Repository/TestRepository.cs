using Dlp.Framework.Container;
using Hackaton.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Core.Repository {
    public class TestRepository : ITestRepository {

        private IConfigurationUtility utility;

        public TestRepository() {

            utility = IocFactory.Resolve<IConfigurationUtility>();

        }

        public long GetMerchantOrderId(long merchantOrderId) {
            throw new NotImplementedException();
        }

        public void GetCreditCardTransactionData(long merchantOrderId) {
            throw new NotImplementedException();
        }
    }
}
