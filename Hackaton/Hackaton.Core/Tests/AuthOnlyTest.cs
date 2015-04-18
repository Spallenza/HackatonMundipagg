using Hackaton.Core.DataContracts;
using Hackaton.Core.Repository;
using Hackaton.Core.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Core.Tests {
    public class AuthOnlyTest : BaseTest {

        public long MerchantOrderId { get; set; }
        public List<CreditCardTransactionData> CreditCardTransactionDataCollection { get; set; }

        public TestResponse Response { get; set; }
        
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

        public override TestResponse VerifyFirstStep(List<CreditCardTransactionData> creditCardTransactionDataCollection, TestRequest testRequest) {

            TestResponse response = new TestResponse();

            CreditCardTransactionData creditCardTransactionData = creditCardTransactionDataCollection.LastOrDefault();

            if (testRequest.TransactionReference != creditCardTransactionData.TransactionReference) {
                AddErrorReport(this.ErrorReportColllection, "TransactionReference", "TransactionReference está errado.");
            }

            else if (testRequest.AmountInCents != creditCardTransactionData.AmountInCents.ToString()) {
                AddErrorReport(this.ErrorReportColllection, "AmountInCents", "AmountInCents está errado.");
            }

            else if (testRequest.AuthorizedAmountInCents != creditCardTransactionData.AuthorizedAmountInCents.ToString()) {
                AddErrorReport(this.ErrorReportColllection, "AuthorizedAmountInCents", "AuthorizedAmountInCents está errado.");
            }

            else if (testRequest.CreditCardTransactionStatusEnum != creditCardTransactionData.CreditCardTransactionStatusEnum) {
                AddErrorReport(this.ErrorReportColllection, "CreditCardTransactionStatusEnum", "CreditCardTransactionStatusEnum errado.");
            }

            else if (testRequest.InstallmentCount != creditCardTransactionData.InstallmentCount.ToString()) {
                AddErrorReport(this.ErrorReportColllection, "CreditCardTransactionStatusEnum", "CreditCardTransactionStatusEnum errado.");
            }

            if (this.ErrorReportColllection.Any() == true) {
                response.Success = false;
            }

            else {
                response.Success = true;
            }
            response.ErrorReportCollection = this.ErrorReportColllection;
            return response;
        }

        public override TestResponse VerifySecondStep(List<CreditCardTransactionData> creditCardTransactionDataCollection, TestRequest testRequest) {

            TestResponse response = new TestResponse();

            CreditCardTransactionData creditCardTransactionData = creditCardTransactionDataCollection.LastOrDefault();

           if (testRequest.AmountInCents != creditCardTransactionData.AmountInCents.ToString()) {
               AddErrorReport(this.ErrorReportColllection, "AmountInCents", "AmountInCents está errado.");
            }

            else if (testRequest.AuthorizedAmountInCents != creditCardTransactionData.AuthorizedAmountInCents.ToString()) {
                AddErrorReport(this.ErrorReportColllection, "AuthorizedAmountInCents", "AuthorizedAmountInCents está errado.");
            }

            else if (testRequest.CreditCardTransactionResultCount != creditCardTransactionDataCollection.Count().ToString()) {
                AddErrorReport(this.ErrorReportColllection, "CreditCardTransactionResultCount", "O número de transações no response está errado.");
            }
            
            else if (testRequest.InstantBuyKey != creditCardTransactionData.InstantBuyKey.ToString().ToUpper()) {
                AddErrorReport(this.ErrorReportColllection, "InstantBuyKey", "InstantBuyKey errado.");
            }

           else if (testRequest.CreditCardTransactionStatusEnum != creditCardTransactionData.CreditCardTransactionStatusEnum) {
               AddErrorReport(this.ErrorReportColllection, "CreditCardTransactionStatusEnum", "CreditCardTransactionStatusEnum errado.");
           }
            
            else if (testRequest.UniqueSequentialNumber != creditCardTransactionData.UniqueSequentialNumber) {
                AddErrorReport(this.ErrorReportColllection, "NSU", "NSU Errado.");
            }


            if (this.ErrorReportColllection.Any() == true) {
                response.Success = false;
            }

            else {
                response.Success = true;
            }
            
            response.ErrorReportCollection = this.ErrorReportColllection;
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

                    AddErrorReport(this.ErrorReportColllection, "", "Erro ao buscar as transações do pedido.");
                }
            }
            else {

                AddErrorReport(this.ErrorReportColllection, "TransactionKey", "Não existe pedido para essa TransactionKey.");

            }

            return sucess;
        
        }


        public void AddErrorReport(List<ErrorReport> ErrorReportColllection, string fieldName, string message) {
            
            ErrorReport errorReport = new ErrorReport();
            errorReport.FieldName = fieldName;
            errorReport.Message = message;

            ErrorReportColllection.Add(errorReport);
        
        }
    }

    
}
