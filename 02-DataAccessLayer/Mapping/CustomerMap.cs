using _01_Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataAccessLayer.Mapping
{
    class CustomerMap : EntityTypeConfiguration<_01_Entity.Customer>
    {
        public CustomerMap()
        {
            HasKey(c => c.CustomerId);

            Property(c => c.CustomerName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(25);

            Property(c => c.CompanyName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(80);
        }

    }
}
