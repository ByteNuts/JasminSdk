using System;
using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.AccountsReceivable.Receipt
{
    public class ReceiptResource
    {
        #region Required Properties

        /// <summary>
        /// Defines the receipt's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default receipt type is defined in the financial setup configuration setting.
        /// (fk) Allowed value: the natural key of a record of type ReceiptType. These records are accessibly through the ReceiptTypes service.
        /// </summary>
        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        /// <summary>
        /// Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the receipt document type.
        /// (fk) Allowed value: the natural key of a record of type Serie. These records are accessibly through the Series service.
        /// </summary>
        [JsonProperty("serie")]
        public string Serie { get; set; }

        /// <summary>
        /// Sequential number internally determined that uniquely identifies the document within the receipt document type and serie. Part of the document natural key.
        /// </summary>
        [JsonProperty("seriesNumber")]
        public int? SeriesNumber { get; set; }

        /// <summary>
        /// The customer designated in the receipt as the party to whom the receipt should be sent. It may or may not be the party to whom the goods or services are delivered. The default is defined on the customer party.
        /// (fk) Allowed value: the natural key of a record of type Party. These records are accessibly through the Parties service.
        /// </summary>
        [JsonProperty("accountingParty")]
        public string AccountingParty { get; set; }

        /// <summary>
        /// The company code is the central organizational unit within the system.
        /// (fk) Allowed value: the natural key of a record of type Company. These records are accessibly through the Companies service.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// The date when the document is issued.
        /// </summary>
        [JsonProperty("documentDate")]
        public DateTime? DocumentDate { get; set; }

        /// <summary>
        /// The date when the document is created.
        /// </summary>
        [JsonProperty("postingDate")]
        public DateTime? PostingDate { get; set; }

        /// <summary>
        /// Money unit used by the system, such as Euros (EUR) or United States Dollars (USD). This value is important for currency exchanges or to set the number of decimal places used to represent values. The default is defined on the customer party.
        /// (fk) Allowed value: the natural key of a record of type Currency. These records are accessibly through the Currencies service.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The price of the document's currency expressed in the company's base currency. In other words, the rate at which the document's currency can be exchanged for the company's base currency. The default is inferred using the defined exchange rates on the system for the document date and currency.
        /// </summary>
        [JsonProperty("exchangeRate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// In some countries, the beneficiary can endorse the check, which allows him or her to specify a third party to whom it should be paid. The name of that third party (in case the payment method used is check).
        /// </summary>
        [JsonProperty("checkEndorsed")]
        public bool? CheckEndorsed { get; set; }

        /// <summary>
        /// Indicates if the payment method used is check. Internally determined. Defined at the payment method.
        /// </summary>
        [JsonProperty("isPaymentMethodCheck")]
        public bool? IsPaymentMethodCheck { get; set; }

        /// <summary>
        /// Total discount over goods and services. Internally calculated.
        /// </summary>
        [JsonProperty("allowanceChargeAmount")]
        public decimal? AllowanceChargeAmount { get; set; }

        /// <summary>
        /// Total value of goods and services before taxes or discounts. Internally calculated.
        /// </summary>
        [JsonProperty("grossValue")]
        public decimal? GrossValue { get; set; }

        /// <summary>
        /// The receipt amount. Total value of goods and services including taxes and discounts. Internally calculated.
        /// </summary>
        [JsonProperty("payableAmount")]
        public decimal? PayableAmount { get; set; }

        /// <summary>
        /// Total withholding tax value of goods and services. Internally calculated.
        /// </summary>
        [JsonProperty("wTaxTotal")]
        public decimal? WTaxTotal { get; set; }

        /// <summary>
        /// Total tax value of goods and services. Internally calculated.
        /// </summary>
        [JsonProperty("taxTotal")]
        public decimal? TaxTotal { get; set; }

        /// <summary>
        /// The receipt total net value. Total value of goods and services after discounts, excluding taxes. Internally calculated.
        /// </summary>
        [JsonProperty("taxExclusiveAmount")]
        public decimal? TaxExclusiveAmount { get; set; }


        #endregion Required Properties



        #region Optional Properties

        /// <summary>
        /// The receipt lines.
        /// </summary>
        [JsonProperty("receiptLines")]
        public List<ReceiptLineResource> ReceiptLines { get; set; }

        /// <summary>
        /// The receipt taxes.
        /// </summary>
        [JsonProperty("receiptTaxes")]
        public List<ReceiptTaxResource> ReceiptTaxes { get; set; }

        /// <summary>
        /// The receipt withholding taxes.
        /// </summary>
        [JsonProperty("receiptWTaxes")]
        public List<ReceiptWTaxResource> ReceiptWTaxes { get; set; }

        /// <summary>
        /// The receipt reporting taxes lines.
        /// </summary>
        [JsonProperty("reportingLines")]
        public List<ReceiptReportingLineResource> ReportingLines { get; set; }

        /// <summary>
        /// The receipt remarks.
        /// </summary>
        [JsonProperty("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// The receipt note.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// The customer address. It is inferred from the customer party.
        /// </summary>
        [JsonProperty("partyAddress")]
        public string PartyAddress { get; set; }

        /// <summary>
        /// Indicates if the receipt has been printed. Internally determined.
        /// </summary>
        [JsonProperty("isPrinted")]
        public bool? IsPrinted { get; set; }

        /// <summary>
        /// Note to the receipt recipient.
        /// </summary>
        [JsonProperty("noteToRecipient")]
        public string NoteToRecipient { get; set; }

        /// <summary>
        /// In some countries, the documents issued by a company have to contain mandatory remarks, clearly visible in printing, which may vary according to the document. These texts are printed under the signature terms. Internally determined.
        /// </summary>
        [JsonProperty("accountingSchemaLegalStamp")]
        public string AccountingSchemaLegalStamp { get; set; }

        /// <summary>
        /// Sentence to be printed on the Receipt, regarding the Payment Methods.
        /// </summary>
        [JsonProperty("paymentMethodStamp")]
        public string PaymentMethodStamp { get; set; }

        /// <summary>
        /// Refers to a cash drawer that collects small amounts of cash in a business. On a receipt either a cash drawer or a bank account must be used to define where to credit the value.
        /// (fk) Allowed value: the natural key of a record of type PettyCash. These records are accessibly through the PettyCashes service.
        /// </summary>
        [JsonProperty("pettyCash")]
        public string PettyCash { get; set; }

        /// <summary>
        /// An account that exists in a financial institution. The financial institution holds someone's money, resulting in a positive balance. It can also be a credit or loans account in which the bank lends money, resulting in a negative balance or debit. Unlike a brokerage account, which allows the investor to buy and sell stocks, a bank account is used for savings. The types of bank accounts include savings accounts and current accounts. On a receipt either a cash drawer or a bank account must be used to define where to credit the value.
        /// (fk) Allowed value: the natural key of a record of type FinancialAccount. These records are accessibly through the FinancialAccounts service.
        /// </summary>
        [JsonProperty("financialAccount")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Incoming and outgoing cash flow caused by the main business activities. The component of the cash flow operations shows how much money is generated by a company's products or services. Generally, the changes made to the cash, banks, accounts receivables and accounts payable affects operational cash. The classification of each of these operations' types is made by using cash flows.
        /// (fk) Allowed value: the natural key of a record of type CashFlowItem. These records are accessibly through the CashFlowItems service.
        /// </summary>
        [JsonProperty("cashFlowItem")]
        public string CashFlowItem { get; set; }

        /// <summary>
        /// The exchange rate creation date.
        /// </summary>
        [JsonProperty("exchangeRateDate")]
        public DateTime? ExchangeRateDate { get; set; }

        /// <summary>
        /// The date of the check (in case the payment method used is check).
        /// </summary>
        [JsonProperty("checkDate")]
        public DateTime? CheckDate { get; set; }

        /// <summary>
        /// The date of the bank that issued the check (in case the payment method used is check).
        /// </summary>
        [JsonProperty("checkBank")]
        public string CheckBank { get; set; }

        /// <summary>
        /// The branch of the bank that issued the check (in case the payment method used is check).
        /// </summary>
        [JsonProperty("checkBranch")]
        public string CheckBranch { get; set; }

        /// <summary>
        /// The branch of the bank that issued the check (in case the payment method used is check).
        /// </summary>
        [JsonProperty("checkAccount")]
        public string CheckAccount { get; set; }

        /// <summary>
        /// The number of the check used for the payment (in case the payment method used is check).
        /// </summary>
        [JsonProperty("checkNumber")]
        public string CheckNumber { get; set; }

        /// <summary>
        /// The place where the check was issued (in case the payment method is check).
        /// </summary>
        [JsonProperty("issuePlace")]
        public string IssuePlace { get; set; }

        /// <summary>
        /// Financial transfer method used by the entity responsible for paying a transaction. For example, cash, transfer or check payments. The default is defined on the customer party.
        /// (fk) Allowed value: the natural key of a record of type PaymentMethod. These records are accessibly through the PaymentMethods service.
        /// </summary>
        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The accounting organization method. The organization can follow the rules of "Cash Accounting" or "Accrual Accounting".
        /// </summary>
        [JsonProperty("accountingSchema")]
        public AccountingSchema AccountingSchema { get; set; }

        /// <summary>
        /// The customer accounting organization method. The customer organication can follow the rules of "Cash Accounting" or "Accrual Accounting".
        /// </summary>
        [JsonProperty("partyAccountingSchema")]
        public AccountingSchema PartyAccountingSchema { get; set; }

        /// <summary>
        /// The receipt notification configuration. Inferred from the receipt type.
        /// (fk) Allowed value: the natural key of a record of type Notification. These records are accessibly through the Notifications service.
        /// </summary>
        [JsonProperty("notification")]
        public string Notification { get; set; }

        /// <summary>
        /// The email(s) to send receipt notification. Inferred from the notification.
        /// </summary>
        [JsonProperty("emailTo")]
        public string EmailTo { get; set; }

        /// <summary>
        /// In some countries, the documents issued by a company have to contain mandatory remarks, clearly visible in printing, which may vary according to the document. These texts are printed under the signature terms. Internally determined.
        /// </summary>
        [JsonProperty("legalStamp")]
        public string LegalStamp { get; set; }


        #endregion Optional Properties
    }
}
