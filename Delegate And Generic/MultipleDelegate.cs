/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegate_And_Generic;

namespace Delegate_And_Generic
{
    delegate void totelDelegate(double wigth, double height);
    class MultipleDelegate
    {
        public void Getarea(double wigth, double higth)
        {
            Console.WriteLine(wigth+higth);
        }
        public void Getperimeter(double wigth, double higth) 
        {
            Console.WriteLine(wigth*higth);

        }
        static void Main()
        {
            
            MultipleDelegate rect=new MultipleDelegate();
            totelDelegate obj = new totelDelegate(rect.Getarea);
            obj += rect.Getperimeter;
            obj.Invoke(12.5, 12.5);
            Console.WriteLine("");
            obj.Invoke(12.5, 10.5);

        }
    }
}*/
