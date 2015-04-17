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
        /// Chave da loja
        /// </summary>
        public string MerchantKey { get; set; }

        /// <summary>
        /// Quantidades de transações de cartão na coleção
        /// </summary>
        public string CreditCardTransactionResultCount { get; set; }

        /// <summary>
        /// Chave da transação
        /// </summary>
        public string TransactionKey { get; set; }

        /// <summary>
        /// Status da transação
        /// </summary>
        public string CreditCardTransactionStatusEnum { get; set; }

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
        public string VoidedInCents { get; set; }

        /// <summary>
        /// Valor estornado
        /// </summary>
        public string RefundedAmountInCents { get; set; }


    }
}
