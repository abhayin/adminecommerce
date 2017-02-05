using Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Admin.EntityConfiguration
{
    public class SocialInformationConfiguration : EntityTypeConfiguration<SocialInformation>
    {
        public SocialInformationConfiguration()
        {
            HasKey(si => si.SocialId)
                .Property(si => si.SocialId)
                .IsRequired();
        }
    }
}