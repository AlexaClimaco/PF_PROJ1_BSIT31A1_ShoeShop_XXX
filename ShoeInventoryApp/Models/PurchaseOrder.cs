using System;
using System.Collections.Generic;

namespace ShoeInventoryApp.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime Date { get; set; }
        public List<ShoeColorVariation> Items { get; set; }
    }
}
