using Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Admin.EntityConfiguration
{
    public class OrderItemConfiguration : EntityTypeConfiguration<OrderItems>
    {
        public OrderItemConfiguration()
        {
            HasKey(oi => oi.OrderItemId)
                .Property(oi => oi.OrderItemId)
                .IsRequired();
        }
    }
}