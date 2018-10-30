using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity;

namespace _02_DataAccessLayer.Mapping
{
    class CustomerDemandMap :EntityTypeConfiguration<CustomerDemand>
    {
        public CustomerDemandMap()
        {
            HasKey(cd => cd.CustomerDemandId);

            Property(cd => cd.Request)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(300);

       

            Property(cd => cd.ProjectId)
                .IsRequired();

            HasRequired(cd => cd.Project)
                .WithMany()
                .HasForeignKey(cd => cd.ProjectId)
                .WillCascadeOnDelete(false); 


        }
    }
}
