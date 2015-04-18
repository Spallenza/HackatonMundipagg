using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Core.Repository {
    public class TestRepository : BaseRepository, ITestRepository {

        public TestRepository(string connectionString)
            : base(connectionString) {

        }

        public long GetMerchantOrderId(long merchantOrderId) {
            throw new NotImplementedException();
        }

        public void GetCreditCardTransactionData(long merchantOrderId) {
            throw new NotImplementedException();
        }
    }
}
