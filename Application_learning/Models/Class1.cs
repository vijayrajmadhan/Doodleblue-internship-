using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application_learning.Models
{
    public class Class1
    {
        public int Summa()
        {
            Console.WriteLine("i am model");
            return 5+6;
        }

        public string Name
        {
            get;
            set;
        }
        public int Id
        {
            get;
            set;
        }
    }
}