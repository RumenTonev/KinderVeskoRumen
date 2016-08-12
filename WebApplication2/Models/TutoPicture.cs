using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class TutoPicture:FileUploadDBModel
    {
        public string TutoNumber { get; set; }
        public string Section { get; set; }
    }
}