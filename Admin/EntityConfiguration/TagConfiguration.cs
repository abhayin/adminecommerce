using Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Admin.EntityConfiguration
{
    public class TagConfiguration : EntityTypeConfiguration<Tags>
    {
        public TagConfiguration()
        {
            HasKey(t => t.TagId)
                .Property(t => t.TagId)
                .IsRequired();

            HasRequired(t => t.Product)
                .WithRequiredDependent(t => t.Tag);

        }
    }
}