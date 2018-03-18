using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ListApp.Models
{  
        public class User
        {
            public int id { get; set; }
            public string userName { get; set; }

            [MinLength(8)]
            [DataType(DataType.Password)]
            public string parol { get; set; }

            public bool isAdmin { get; set; }
        }
}