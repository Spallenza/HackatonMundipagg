using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Core.Repository.Entity {
    public class CreditCardTransactionData {

        /// <summary>
        /// Quantidades de transações de cartão na coleção
        /// </summary>
        public string CreditCardTransactionResultCount { get; set; }

        /// <summary>
        /// Referência do lojista para a transação
        /// </summary>
        public string TransactionReference { get; set; }

        /// <summary>
        /// Chave da transação
        /// </summary>
        public Guid TransactionKey { get; set; }

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
        public Guid InstantBuyKey { get; set; }

        /// <summary>
        /// NSU
        /// </summary>
        public string UniqueSequentialNumber { get; set; }

        /// <summary>
        /// Valor da transação.
        /// </summary>
        public long AmountInCents { get; set; }

        /// <summary>
        /// Valor autorizado
        /// </summary>
        public long AuthorizedAmountInCents { get; set; }

        /// <summary>
        /// Valor Capturado
        /// </summary>
        public long CapturedAmountInCents { get; set; }

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
