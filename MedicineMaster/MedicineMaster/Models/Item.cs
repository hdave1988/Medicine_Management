//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicineMaster.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public Item()
        {
            this.PrescriptionItems = new HashSet<PrescriptionItem>();
            this.PurchaseItems = new HashSet<PurchaseItem>();
        }
    
        public int ItemId { get; set; }
        public int ItemCode { get; set; }
        public string Description { get; set; }
        public decimal TotalQuantity { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal GST { get; set; }
        public System.DateTime ExpireyDate { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public System.DateTime PrescriptionDate { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<PrescriptionItem> PrescriptionItems { get; set; }
        public virtual ICollection<PurchaseItem> PurchaseItems { get; set; }
    }
}
