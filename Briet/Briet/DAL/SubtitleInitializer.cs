using Briet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Briet.DAL
{
    public class SubtitleInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<AppDataContext>
    {
        protected override void Seed(AppDataContext context)
        {
            var subtitles = new List<SubtitleItem>
            {
                new SubtitleItem{
                    Title="The Amazing Spiderman",
                    Language="Icelandic",
                    Category="Movies",
                    PublishDate=DateTime.Parse("2014-02-20 14:30:00")
                },
                new SubtitleItem{
                    Title="The Big Bang Theory",
                    Language="Spanish",
                    Category="TV Shows",
                    PublishDate=DateTime.Parse("2014-03-20 15:45:29")
}
            };
            subtitles.ForEach(s => context.Subtitles.Add(s));
            context.SaveChanges();
        }
    }
}