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
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.OrderDetails = new ObservableCollection<OrderDetails>();
        }
    
        public long ID_Order { get; set; }
        public System.DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public long ID_Client { get; set; }
        public long ID_Employee { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Employees Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<OrderDetails> OrderDetails { get; set; }
    }
}