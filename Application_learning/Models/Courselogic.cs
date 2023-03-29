using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application_learning.Models
{
    public class Courselogic
    {
        public Course CourseDetails()
        {
            Course obj = new Course()
            {
                Title = "C# Course",
                StudentEnrolled = 100,
                Rating = 7,
                Fees = 1500
            };

            return obj;
        }
       
    }
}