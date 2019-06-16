using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_Librarian.Classes;

namespace Code_Librarian.Models
{
    [DbConfigurationType(typeof(SqliteConfiguration))]
    public class AppDbContext : DbContext
    {
        private static readonly SQLiteConnection SQLiteConnectionString = new SQLiteConnection()
        {
            ConnectionString = (new SQLiteConnectionStringBuilder() // @"data source=...\CodeLib.sqlite3;foreign keys=True"
            {
                DataSource = AppConfiguration.Instance.GetDbPath(),
                ForeignKeys = true
            }).ConnectionString
        };

        public AppDbContext() : base(SQLiteConnectionString, true)
        {
            // Forces code first migrations to be ignored.
            Database.SetInitializer<AppDbContext>(null);
        }

        public DbSet<Snippet> Snippets { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
