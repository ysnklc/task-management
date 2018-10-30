    using _01_Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataAccessLayer.Mapping
{
    class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            HasKey(e => e.EmployeeId);

            
            Property(e => e.FirstName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(25);

            Property(e => e.LastName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(25);

            Property(e => e.IdentityNumber)
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(11);
            Property(e => e.Password)
               .IsRequired()
               .HasColumnType("nvarchar")
               .HasMaxLength(25);

            Property(e => e.Phone)
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(10);

            Property(e => e.Address)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(200);

            Property(e => e.Password)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);




            Property(e => e.EmployeeRoleId)
                .IsRequired();

            HasRequired(e => e.EmployeeRole)
                .WithMany()
                .HasForeignKey(e => e.EmployeeRoleId)
                .WillCascadeOnDelete(false);


        }
    }
}
