using Hackaton.Core.DataContracts;
using Hackaton.Core.Repository;
using Hackaton.Core.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Core.Tests {
    public class CaptureTest : BaseTest {

        public long MerchantOrderId { get; set; }
        public List<CreditCardTransactionData> CreditCardTransactionDataCollection { get; set; }

        public TestResponse Response { get; set; }

        public List<ErrorReport> ErrorReportColllection { get; set; }

        public override TestResponse Execute(TestRequest testRequest) {



            if (testRequest.TestStep == "1") {

                if (Validate(testRequest) == true) {
                    Response = this.VerifyFirstStep(CreditCardTransactionDataCollection, testRequest);
                }

            }
            else if (testRequest.TestStep == "2") {

                if (Validate(testRequest) == true) {
                    Response = this.VerifySecondStep(CreditCardTransactionDataCollection, testRequest);
                }
            }



            return Response;

        }

        public override TestResponse VerifyFirstStep(List<CreditCardTransactionData> creditCardTransactionData, TestRequest testRequest) {

            TestResponse response = new TestResponse();
            return response;
        }

        public override TestResponse VerifySecondStep(List<CreditCardTransactionData> creditCardTransactionData, TestRequest testRequest) {

            TestResponse response = new TestResponse();
            return response;
        }

        public bool Validate(TestRequest testRequest) {

            bool sucess = false;

            TestRepository repository = new TestRepository();

            MerchantOrderId = repository.GetMerchantOrderId(Guid.Parse(testRequest.TransactionKey), Guid.Parse(testRequest.MerchantKey));

            if (MerchantOrderId > 0) {

                CreditCardTransactionDataCollection = repository.GetCreditCardTransactionData(MerchantOrderId);

                if (CreditCardTransactionDataCollection.Any() == true) {

                    sucess = true;

                }
                else {
                    ErrorReport report = new ErrorReport();

                    report.FieldName = "";
                    report.Message = "Erro ao buscar as transações do pedido.";

                    ErrorReportColllection.Add(report);
                }
            }
            else {
                ErrorReport report = new ErrorReport();

                report.FieldName = "TransactionKey";
                report.Message = "Não existe pedido para essa TransactionKey.";
                ErrorReportColllection.Add(report);
            }

            return sucess;

        }
    }
}
