using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_And_Generic
{
    public class DelegatePreDefined
    {
        public static double AddNums1(int x,float y,double z)
        {
            return x + y + z;
        }
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool AddNums3(int x)
        {
            if(x>0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        static void Main()
        {
            Func<int, float, double, double> obj1 = AddNums1;
            double result = obj1.Invoke(100, 20.5f, 34.5);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = AddNums2;
            obj2.Invoke(10, 20.5f, 34.5f);

            Predicate<int> obj3 = AddNums3;
            bool result2=obj3.Invoke(100);
            Console.WriteLine(result2);
        }

    }
    
}
