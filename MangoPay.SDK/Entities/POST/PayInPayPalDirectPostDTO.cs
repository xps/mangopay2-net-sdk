﻿using System.Collections.Generic;
using MangoPay.SDK.Core.Enumerations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MangoPay.SDK.Entities.POST
{
    /// <summary>PayIn by PayPal Direct POST entity.</summary>
    public class PayInPayPalDirectPostDTO : EntityPostBase
    {
        public PayInPayPalDirectPostDTO(
            string authorId,
            Money debitedFunds,
            Money fees,
            string creditedWalletId,
            string returnURL,
            List<LineItem> lineItems,
            Shipping shipping = null,
            string statementDescriptor = null,
            CultureCode? culture = null
        )
        {
            AuthorId = authorId;
            DebitedFunds = debitedFunds;
            Fees = fees;
            CreditedWalletId = creditedWalletId;
            ReturnURL = returnURL;
            LineItems = lineItems;
            Shipping = shipping;
            StatementDescriptor = statementDescriptor;
            Culture = culture;
        }

        /// <summary>Author identifier.</summary>
        public string AuthorId { get; set; }

        /// <summary>Debited funds.</summary>
        public Money DebitedFunds { get; set; }

        /// <summary>Fees.</summary>
        public Money Fees { get; set; }

        /// <summary>Credited wallet identifier.</summary>
        public string CreditedWalletId { get; set; }

        /// <summary>Culture (language).</summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public CultureCode? Culture { get; set; }

        /// <summary>Return URL.</summary>
        public string ReturnURL { get; set; }

        /// <summary>Information about the items bought by the customer</summary>
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// User’s shipping address
        /// When not provided, the default address is the one register one the buyer PayPal account
        /// </summary>
        public Shipping Shipping { get; set; }

        /// <summary>
        /// Custom description to appear on the user’s bank statement along with the platform name.
        /// Note that a particular bank may show more or less information.
        /// </summary>
        public string StatementDescriptor { get; set; }
    }
}