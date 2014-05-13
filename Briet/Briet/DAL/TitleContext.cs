using Briet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Briet.DAL
{
    public class TitleContext: DbContext 
    {
        public DbSet<Title> Titles { get; set; }

    }
    public class Title
    {
        public int Id { get; set; }
        public string TitleName { get; set; }
        public int Language { get; set; }
        public string SubFileSRT { get; set; }
        public string MediaURL { get; set; }
        public DateTime PublishDate { get; set; }
        public bool Status { get; set; }

        public Title()
        {
            PublishDate = DateTime.Now;
        }
    }
}