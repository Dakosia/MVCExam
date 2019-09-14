//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCExamShop.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescriptionInText { get; set; }
        public string ProductDescriptionInHTML { get; set; }
        public Nullable<double> ProductOldPrice { get; set; }
        public double ProductNewPrice { get; set; }
        public double ProductExTaxPrice { get; set; }
        public string ProductAvailability { get; set; }
        public int ProductQtyInStock { get; set; }
        public string ProductImagePath { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}
