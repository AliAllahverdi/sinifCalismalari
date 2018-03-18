using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListApp.Models
{
    public class Task
    {
        public int id { get; set; }
        public string title { get; set; }
        public string userid { get; set; }
        public DateTime deadline { get; set; }
        public string description { get; set; }
        public string status { get; set; }

        public virtual User userTask { get; set; }
    }
}