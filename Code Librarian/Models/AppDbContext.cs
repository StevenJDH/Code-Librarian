/**
 * This file is part of Code Librarian <https://github.com/StevenJDH/Code-Librarian>.
 * Copyright (C) 2019 Steven Jenkins De Haro.
 *
 * Code Librarian is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * Code Librarian is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with Code Librarian.  If not, see <http://www.gnu.org/licenses/>.
 */

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
