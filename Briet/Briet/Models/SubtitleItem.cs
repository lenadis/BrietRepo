using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Briet.Models
{
    public class SubtitleItem
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public string Language { get; set; }
        public string Category { get; set; }
        public DateTime PublishDate { get; set; }
        public bool Status { get; set; } 

        public SubtitleItem()
        {
            PublishDate = DateTime.Now;
        }
    }
}