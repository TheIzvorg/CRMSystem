//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRMSystem.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentHistory
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public System.DateTime Date { get; set; }
        public int UserId { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
