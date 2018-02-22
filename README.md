# JasminSdk
.Net SDK for Jasmin Software from Primavera BSS

![Master branch status](https://ci.appveyor.com/api/projects/status/github/bytenuts/jasminsdk?svg=true&branch=master)

## Basic setup

**1. Install the JasminSdk NuGet package**

You can download and install this SDK package using NuGet.

There are 3 NuGet packages associated with this SDK:

- **JasminSdk.AspNetCore** - For .Net Core applications
- **JasminSdk.Mvc** - For MVC 5 applications
- **JasminSdk** - The core of the SDK (can be used standalone with any .NET Standard 2.0 compatible app)


Install the appropriate package using the Package Manager UI or through the console:

	Install-Package JasminSdk.AspNetCore

**2. Register the Sdk**

On AspNetCore, register it on the ConfigureServices method in Startup.cs class as following:

	services.AddJasminSdk(new JasminConfig
    {
        AccountKey = "xxxxxx",
        SubscriptionKey = "xxxxxx-xxxx",
        ClientId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
        ClientSecret = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
    });

On Mvc, register it on Global.asax.cs as following:

	JasminSdkConfig.UseJasminSdk(new JasminConfig
    {
        AccountKey = "xxxxxx",
        SubscriptionKey = "xxxxxx-xxxx",
        ClientId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
        ClientSecret = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
    });

```
Please note that the Sdk does not implement all Jasmin features yet.
Feel free to contribute if you have some free time!
```

> Refer to the samples repository for examples.

> [Samples repository](https://github.com/ByteNuts/JasminSdk.Samples)



## Implemented features

- [ ] **Accounts Payable** 
	- [ ] Create Payment
- [x] **Accounts Receivable** :white_check_mark:
	- [x] Create Receipt
	- [x] Receipt
- [ ] **Financials**
	- [ ] Account Posting
	- [ ] Account Transaction
	- [ ] Accounting Entry
	- [ ] Accounts Entry
	- [ ] Cash Flow Item
	- [ ] Financial Account
	- [ ] Financial Institution
	- [ ] Financial Setup
	- [ ] Payment Method
	- [ ] Payment Term
	- [ ] Payment Type
	- [ ] Petty Cash
	- [ ] Receipt Type
- [ ] **Goods Receipt**
	- [ ] Process Order
- [ ] **Logistics**
	- [ ] Delivery Term
	- [ ] Delivery Type
	- [ ] Goods Receipt Type
	- [ ] Materials Setup
	- [ ] Memo Reason
	- [ ] Shipping Method
- [ ] **Master Data Business Entities**
	- [ ] Assortment
	- [ ] Brand
	- [ ] Entity
	- [ ] Exchange Rates Document
	- [x] Item
	- [ ] Model
	- [ ] Serie
- [ ] **Materials Management**
	- [ ] Adjustment Reason
	- [ ] Item Adjustment
	- [ ] Item Subtype
	- [x] Materials Item
	- [ ] Materials Setup
	- [ ] Stock Transfer Order
	- [ ] Warehouse
- [ ] **Online Store**
	- [ ] ECommerce Item
	- [ ] ECommerce List Items
	- [ ] ECommerce Setup
	- [ ] Item Category
- [ ] **Platform**
	- [ ] Address
	- [ ] Company
	- [ ] Contact
	- [ ] Contact Group
	- [ ] Contact Type
	- [ ] Country
	- [ ] Culture
	- [ ] Currency
	- [ ] Draft
	- [ ] Email Template
	- [ ] Fiscal Time Zone
	- [ ] Import Data Info
	- [ ] Notification
	- [ ] Operation
	- [ ] Postal Code
	- [ ] Power Bi Info
	- [ ] Region
	- [ ] Sequence
	- [ ] Unit
	- [ ] Unit Dimension
- [ ] **Purchases**
	- [ ] Credit or Debit Note
	- [ ] Expense
	- [ ] Invoice
	- [ ] Invoice Receipt Notification
	- [ ] Invoice Type
	- [ ] Memo Type
	- [ ] Order
	- [ ] Order Type
	- [ ] Process Order
	- [ ] Process Return Order
	- [ ] Purchase Item
	- [ ] Purchases Setup
	- [ ] Summary Value
	- [ ] Supplier
	- [ ] Supplier Group
- [ ] **Sales**
	- [ ] Company Invoice
	- [ ] Credit or Debit Note
	- [ ] Customer Group
	- [x] Customer Party
	- [x] Invoice
	- [ ] Invoice Type
	- [ ] Memo Type
	- [ ] Order
	- [ ] Order Type
	- [ ] Price List
	- [ ] Process Order
	- [ ] Process Return Order
	- [ ] Quotation
	- [ ] Quotation Type
	- [ ] Sales Channel
	- [x] Sales Item
	- [ ] Sales Setup
	- [ ] Salesperson
- [ ] **Shipping**
	- [ ] Delivery
	- [ ] Process Order
	- [ ] Shipping Request
- [ ] **Taxes**
	- [ ] AT Communication Request
	- [ ] Economic Activity Classification
	- [ ] Exemption Reason Code
	- [ ] Fiscal Document Type
	- [ ] Fiscal Witholding Tax Type
	- [ ] Item Tax Schema
	- [ ] Item WHT Schema
	- [ ] Obligation
	- [ ] Party Tax Schema
	- [ ] Party WHT Schema
	- [ ] Payment Method Fiscal Class
	- [ ] SAF-T (PT)
	- [ ] Tax Class
	- [ ] Tax Classification
	- [ ] Tax Regional Area
	- [ ] Tax Sub Class
	- [ ] Tax Type Code
	- [ ] Taxes Setup
	- [ ] WHT Code
	- [ ] WHT Type
