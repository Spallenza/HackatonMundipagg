using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Core.DataContracts {
    public class TestRequest {

        /// <summary>
        /// Identificador do teste
        /// </summary>
        public string TestId { get; set; }

        /// <summary>
        /// Identificador da parte do teste
        /// </summary>
        public string TestStep { get; set; }

        /// <summary>
        /// Chave da loja
        /// </summary>
        public string MerchantKey { get; set; }

        /// <summary>
        /// Quantidades de transações de cartão na coleção
        /// </summary>
        public string CreditCardTransactionResultCount { get; set; }

        /// <summary>
        /// Referência do lojista para a transação
        /// </summary>
        public string TransactionReference { get; set; }

        /// <summary>
        /// Operação da transação
        /// </summary>
        public string CreditCardOperationEnum { get; set; }

        /// <summary>
        /// Chave da transação
        /// </summary>
        public string TransactionKey { get; set; }

        /// <summary>
        /// Status da transação
        /// </summary>
        public string CreditCardTransactionStatusEnum { get; set; }

        /// <summary>
        /// Quantidade de Parcelas
        /// </summary>
        public string InstallmentCount { get; set; }

        /// <summary>
        /// Valor do Success
        /// </summary>
        public string Success { get; set; }

        /// <summary>
        /// InstantBuyKey
        /// </summary>
        public string InstantBuyKey { get; set; }

        /// <summary>
        /// NSU
        /// </summary>
        public string UniqueSequentialNumber { get; set; }

        /// <summary>
        /// Valor da transação.
        /// </summary>
        public string AmountInCents { get; set; }

        /// <summary>
        /// Valor autorizado
        /// </summary>
        public string AuthorizedAmountInCents { get; set; }

        /// <summary>
        /// Valor Capturado
        /// </summary>
        public string CapturedAmountInCents { get; set; }

        /// <summary>
        /// Valor cancelado
        /// </summary>
        public string VoidedAmountInCents { get; set; }

        /// <summary>
        /// Valor estornado
        /// </summary>
        public string RefundedAmountInCents { get; set; }


    }
}
