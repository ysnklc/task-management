using _01_Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataAccessLayer.Mapping
{
    class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            HasKey(p => p.ProjectId);

            Property(p => p.ProjectName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            Property(p => p.Description)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(300);

            Property(p => p.StartingDate)
                .IsRequired()
                .HasColumnType("datetime");

            Property(p => p.FinishDate)
                .IsRequired()
                .HasColumnType("datetime");

          

            Property(p => p.CustomerId)
                .IsRequired();

            HasRequired(p => p.Customer)
                .WithMany()
                .HasForeignKey(p => p.CustomerId)
                .WillCascadeOnDelete(false); 
        }
    }
}
