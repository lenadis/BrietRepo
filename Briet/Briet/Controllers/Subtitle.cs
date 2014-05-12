using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Briet.Controllers
{
    public class Subtitle
    {
        public int ID { get; set; }
        public int TitleID { get; set; }
        public int LanguageID { get; set; }
        public DateTime PublishDate { get; set; }
        public bool Status { get; set; } 

        public Subtitle()
        {
            PublishDate = DateTime.Now;
        }
    }
}