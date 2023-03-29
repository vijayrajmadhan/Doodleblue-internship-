using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application_learning.Models
{
    public class Course
    {
        public string Title //properties
        {
            get;
            set;
        }
        public int StudentEnrolled
        {
            get;
            set;
        }
        public int Rating
        {
            get;
            set;
        }
        public int Fees
        {
            get;
            set;
        }
    }
}