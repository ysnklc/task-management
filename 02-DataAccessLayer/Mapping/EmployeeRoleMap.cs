using _01_Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataAccessLayer.Mapping
{
    class EmployeeRoleMap : EntityTypeConfiguration<EmployeeRole>
    {
        public EmployeeRoleMap()
        {
            HasKey(j => j.EmployeeRoleId);

            Property(j => j.RoleName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(30);

        }
    }
}
