using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Briet.Controllers
{
    public class Titles
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int CategoryID { get; set; }
        public string SubFileSRT { get; set; }
        public string MediaURL { get; set; }
    }
}