/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_And_Generic
{
    public class Generic1
    {
        public bool Compare<T>(T x, T y)
        {
            if (x.Equals(y)) return true;
            return false;
        }
        public int CustID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public int Balance
        {
            get;
            set;
        }
        static void Main()
        {
            Generic1 obj = new Generic1();
            bool result = obj.Compare<int>(10, 10);
            Console.WriteLine(result);

            List<Generic1> Customer = new List<Generic1>();
            Generic1 c1 = new Generic1 { CustID = 101, Name = "Vijay", City = "Coimbatore", Balance = 2000 };
            Generic1 c2 = new Generic1 { CustID = 102, Name = "Chakaravarthy", City = "Chennai", Balance = 2001 };
            Generic1 c3 = new Generic1 { CustID = 103, Name = "Sarath", City = "Bangalore", Balance = 2002 };

            Customer.Add(c1);
            Customer.Add(c2);
            Customer.Add(c3);

            foreach(Generic1 va in Customer)
            {
                Console.WriteLine(va.CustID + " " + va.Name + " " + va.City + " " + va.Balance);
            }
        }

       
    }
}
*/