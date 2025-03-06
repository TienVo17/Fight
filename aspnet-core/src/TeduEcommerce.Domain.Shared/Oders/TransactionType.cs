using System;
using System.Collections.Generic;
using System.Text;

namespace TeduEcommerce.Oders
{
    public enum TransactionType
    {
        ConfirmOrder,
        StartProcessing,
        FinishOrder,
        CancelOrder
    }
}
