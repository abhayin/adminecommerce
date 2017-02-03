using Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Admin.EntityConfiguration
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.ProductId)
                .Property(p => p.ProductId)
                .IsRequired();

            //HasOptional(p => p.Category)
            //    .WithRequired(p => p.Product);

            Property(p=>p.ProductName)
                .IsRequired()
                .HasMaxLength(255);

            Property(p => p.Price)
                .IsRequired();


        }
    }
}