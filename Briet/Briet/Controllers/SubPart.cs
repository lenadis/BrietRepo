using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Briet.Controllers
{
    public class SubPart
    {
        public int Id { get; set; }
        public int SubtitleID { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string MediaURLExtension { get; set; }
    }
}