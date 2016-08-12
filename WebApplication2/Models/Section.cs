using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Section
    {
        [DisplayName("Select File to Upload")]
        public string Name { get; set; }
        public string TutoNumber { get; set; }
        public IEnumerable<HttpPostedFileBase> Files { get; set; }
    }
}