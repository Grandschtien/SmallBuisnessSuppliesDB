//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmallBuisnessSupplies
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class VW_ClientOrder
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public System.DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public short Quantity { get; set; }
        public decimal PrCost { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
    }
}
