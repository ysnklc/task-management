    using _01_Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataAccessLayer.Mapping
{
    class TasksMap : EntityTypeConfiguration<Tasks>
    {
        public TasksMap()
        {
            HasKey(t => t.TaskId);

            Property(t => t.TaskName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            Property(t => t.StartingDate)
                .IsRequired()
                .HasColumnType("datetime");

            Property(t => t.FinishDate)
                .IsRequired()
                .HasColumnType("datetime");

            Property(t => t.StateId)
                .IsRequired();

            HasRequired(t => t.State)
                .WithMany()
                .HasForeignKey(t => t.StateId)
                .WillCascadeOnDelete(false);

            Property(t => t.ProjetId)
                .IsRequired();

            HasRequired(t => t.Project)
                .WithMany()
                .HasForeignKey(t => t.ProjetId)
                .WillCascadeOnDelete(false);

         
                
            

        }
    }
}
