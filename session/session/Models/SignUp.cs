using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace session.Models
{
    
    public class SignUp
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string mail { get; set; }

        //[Range(0, 120)]
        public int age { get; set; }
    }
}