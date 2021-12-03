
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Agro.Tag.Core.Entities;



namespace Agro.Tag.EF.BD.Infrastructure.DAL
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ):base(options)
        {
            
            /*
            System.Configuration.LazyLoadingEnabled = false;
            Database.Log = x => Trace.WriteLine(x);
            */           
        }

        public DbSet<Core.Entities.Tag> Tag { get; set; }

        /*
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
        {
            
            OnBeforeSaving();
            return base.SaveChangesAsync(cancellationToken);
        }
        */

        /*
        private void OnBeforeSaving()
        {
            var entries = ChangeTracker.Entries();
            var utcNow = DateTime.UtcNow;

            foreach (var entry in entries)
            {
                // for entities that inherit from BaseEntity,
                // set UpdatedOn / CreatedOn appropriately
                if (entry.Entity is BaseEntity trackable)
                {
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            // set the updated date to "now"
                            trackable.UpdatedAt = utcNow;
                            // mark property as "don't touch"
                            // we don't want to update on a Modify operation
                            entry.Property("CreatedAt").IsModified = false;
                            break;

                        case EntityState.Added:
                            // set both updated and created date to "now"
                            trackable.CreatedAt = utcNow;
                            trackable.UpdatedAt = utcNow;
                            break;
                    }
                }
            }
        }

      */

        /*
        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Core.Entities.Tag>().HasKey(e => e.Id);
           
            base.OnModelCreating(modelBuilder);
        }
        */
    }
}
