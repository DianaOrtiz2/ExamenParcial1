using System;
namespace WAExamenParcial1.Models
{
    public class ProductModel : EntityBase
    {
        public decimal price { get; set; }
        public int  Quantity { get; set; }
        public DateTime LastMovement {  get; set; }
    }
}