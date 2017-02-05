using Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Admin.EntityConfiguration
{
    public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            HasKey(a => a.AddressId)
                .Property(a => a.AddressId)
                .IsRequired();

            HasRequired(a => a.User)
                .WithMany(a => a.Address)
                .HasForeignKey(a => a.UserId);
            
        }
    }
}