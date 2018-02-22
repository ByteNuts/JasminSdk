using System;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core
{
    public static class Constants
    {
        internal static string JasminBaseIdentityUrl => "https://identity.primaverabss.com/core/connect/token";
        internal static string JasminBaseAppUrl => "https://my.jasminsoftware.com";

        public static JasminConfig Config { get; set; }

        internal static string AccessToken { get; set; }
        internal static DateTime AccessTokenLifetime { get; set; }


        #region Accounts Payable

        internal static string SubPath_AccountsPayable_CreatePayment => "accountsPayable/processOpenItems";

        #endregion Accounts Payable


        #region Accounts Receivable

        internal static string SubPath_AccountsReceivable_CreateReceipt => "accountsReceivable/processOpenItems";
        internal static string SubPath_AccountsReceivable_Receipt => "accountsReceivable/receipts";

        #endregion Accounts Receivable


        #region Financials

        internal static string SubPath_Financials_AccountPosting => "financialCore/accountPostings";
        internal static string SubPath_Financials_AccountTransaction => "financialCore/accountTransactions";
        internal static string SubPath_Financials_AccountingEntry => "financialCore/accountingEntries";
        internal static string SubPath_Financials_AccountsEntry => "financialCore/accountsEntries";
        internal static string SubPath_Financials_CashFlowItem => "financialCore/cashFlowItems";
        internal static string SubPath_Financials_FinancialAccount => "financialCore/financialAccounts";
        internal static string SubPath_Financials_FinancialInstitution => "financialCore/financialInstitutions";
        internal static string SubPath_Financials_FinancialSetup => "financialCore/financialSetups";
        internal static string SubPath_Financials_PaymentMethod => "financialCore/paymentMethods";
        internal static string SubPath_Financials_PaymentTerm => "financialCore/paymentTerms";
        internal static string SubPath_Financials_PaymentType => "financialCore/paymentTypes";
        internal static string SubPath_Financials_PettyCash => "financialCore/pettyCashes";
        internal static string SubPath_Financials_ReceiptType => "financialCore/receiptTypes";

        #endregion Financials


        #region Goods Receipt

        internal static string SubPath_GoodsReceipt_ProcessOrder => "goodsReceipt/processOrders";

        #endregion Goods Receipt


        #region Logistics

        internal static string SubPath_Logistics_DeliveryTerm => "logisticsCore/deliveryTerms";
        internal static string SubPath_Logistics_DeliveryType => "logisticsCore/deliveryTypes";
        internal static string SubPath_Logistics_GoodsReceiptType => "logisticsCore/goodsReceiptNoteTypes";
        internal static string SubPath_Logistics_MaterialsSetup => "logisticsCore/logisticsSetups";
        internal static string SubPath_Logistics_MemoReason => "logisticsCore/memoReasons";
        internal static string SubPath_Logistics_ShippingMethod => "logisticsCore/shippingMethods";

        #endregion Logistics


        #region Master Data Business Entities

        internal static string SubPath_MasterDataBusinessEntities_Item => "businessCore/items";

        #endregion Master Data Business Entities


        #region Materials Management

        internal static string SubPath_MaterialsManagement_ => "";

        #endregion Materials Management


        #region Online Store

        internal static string SubPath_OnlineStore_ => "";

        #endregion Online Store


        #region Platform

        internal static string SubPath_Platform_ => "";

        #endregion Platform


        #region Purchases

        internal static string SubPath_Purchases_CreditOrDebitNote => "invoiceReceipt/memos";
        internal static string SubPath_Purchases_Expense => "invoiceReceipt/expenses";
        internal static string SubPath_Purchases_Invoice => "invoiceReceipt/invoices";
        internal static string SubPath_Purchases_InvoiceReceiptNotification => "invoiceReceipt/invoiceReceiptNotifications";
        internal static string SubPath_Purchases_InvoiceType => "purchasesCore/invoiceTypes";
        internal static string SubPath_Purchases_MemoType => "purchasesCore/memoTypes";
        internal static string SubPath_Purchases_Order => "purchases/orders";
        internal static string SubPath_Purchases_OrderType => "purchasesCore/orderTypes";
        internal static string SubPath_Purchases_ProcessOrder => "invoiceReceipt/processOrders";
        internal static string SubPath_Purchases_ProcessReturnOrder => "invoiceReceipt/processReturnOrders";
        internal static string SubPath_Purchases_PurchaseItem => "purchasesCore/purchasesItems";
        internal static string SubPath_Purchases_PurchasesSetup => "purchasesCore/purchasesSetups";
        internal static string SubPath_Purchases_SummaryValue => "purchases/summaryValues";
        internal static string SubPath_Purchases_Supplier => "purchasesCore/supplierParties";
        internal static string SubPath_Purchases_SupplierGroup => "purchasesCore/supplierGroups";

        #endregion Purchases


        #region Sales

        internal static string SubPath_Sales_CustomerParty => "salesCore/customerParties";
        internal static string SubPath_Sales_Invoice => "billing/invoices";
        internal static string SubPath_Sales_SalesItem => "salesCore/salesItems";

        #endregion Sales


        #region Shipping

        internal static string SubPath_Shipping_ => "";

        #endregion Shipping


        #region Taxes

        internal static string SubPath_Taxes_ => "";

        #endregion Taxes

    }
}
