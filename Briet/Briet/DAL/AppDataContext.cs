using Briet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Briet.DAL
{
    public class AppDataContext: DbContext 
    {
        public AppDataContext()
            : base("SubtitleContext")
        {

        }
        public DbSet<SubtitleItem> Subtitles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}