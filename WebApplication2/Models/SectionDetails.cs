using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class SectionDetails
    {
        public IEnumerable<TutoPicture> FirstTutorial { get; set; }
        public IEnumerable<TutoPicture> SecondTutorial { get; set; }
        public IEnumerable<TutoPicture> ThirdTutorial { get; set; }
    }
}