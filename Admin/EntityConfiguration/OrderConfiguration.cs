using Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;


namespace Admin.EntityConfiguration
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasKey(o => o.OrderId)
                .Property(o => o.OrderId)
                .IsRequired();

            HasMany(o => o.Items)
                .WithRequired(o => o.Order)
                .HasForeignKey(o => o.OrderId);
        }
    }
}