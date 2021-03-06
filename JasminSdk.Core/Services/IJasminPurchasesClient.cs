﻿using ByteNuts.PrimaveraBss.JasminSdk.Core.Services.Purchases;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public interface IJasminPurchasesClient
    {
        IInvoice Invoice { get; }

        IPurchaseItem PurchaseItem { get; }

        ISupplier Supplier { get; }

    }
}
