using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace TourismDictionary.Data.DataAccess.SqlServer {

    public class GlossaryContext : DbContext {

        public GlossaryContext()
        {
            Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");
            Database.SetInitializer<GlossaryContext>(new DropCreateIfChangeInitializer());
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Word> Words { get; set; }
        public DbSet<Meaning> Meanings { get; set; }

        class DropCreateIfChangeInitializer : DropCreateDatabaseIfModelChanges<GlossaryContext> {

            protected override void Seed(GlossaryContext context) {

                context.Words.Add(new Word { 
                    Name = "Tourism",
                    Meanings = new List<Meaning>() { 
                        new Meaning { Description = "Tourism is a collection of activities, services and industries which deliver a travel experience comprising transportation, accommodation, eating and drinking establishments, retail shops, entertainment businesses and othe hospitality services provided for individuals or groups traveling away from home" },
                        new Meaning { Description = "Tourism comprises the activities of persons traveling to and staying in places outside their usual environment for not more than one consecutive year for leisure, business and other purposes." }
                    }
                });

                base.Seed(context);
            }
        }
    }
}