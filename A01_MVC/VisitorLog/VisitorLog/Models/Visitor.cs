using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VisitorLog.Models
{
    public class Visitor
    {
        [Key]
        public int VisitorID { get; set; }
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Display(Name = "Logged in at")]
        public DateTime LoginTime { get; set; }
        [Display(Name = "From Ip Address")]
        public string IpAdress { get; set; }
    }
}