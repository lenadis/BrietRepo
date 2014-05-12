using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Briet.Controllers
{
    public class SubPartText
    {
        public int Id { get; set; }
        public int SubPartID { get; set; }
        public int LanguageID { get; set; }
        public int UserID { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
    }
}