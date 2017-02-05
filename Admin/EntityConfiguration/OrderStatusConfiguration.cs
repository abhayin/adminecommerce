using Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Admin.EntityConfiguration
{
    public class OrderStatusConfiguration : EntityTypeConfiguration<OrderStatus>
    {
        public OrderStatusConfiguration()
        {
            HasKey(os => os.StatusId)
                .Property(os => os.StatusId)
                .IsRequired();

            HasRequired(os => os.Order)
                .WithRequiredPrincipal(os => os.Status);

        }
    }
}