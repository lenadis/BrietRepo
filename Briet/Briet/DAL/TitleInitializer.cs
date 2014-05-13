using Briet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Briet.DAL
{
    public class TitleInitializer
    {
        static void Main(string[] args)
        {
            using (var db = new TitleContext())
            {
                db.Titles.Add(new Title { TitleName = "Some Movie Title" });
                db.SaveChanges();

                foreach (var Title in db.Titles )
                {
                    Console.WriteLine(Title.TitleName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}