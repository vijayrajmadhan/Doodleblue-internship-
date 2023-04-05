/*using Delegate_And_Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_And_Generic
{
    public delegate void carDelegate(Car obj);
    public class Vehicle
    {
        public void Printvechical(Vehicle obj)
        {
            Console.WriteLine(obj.GetHashCode());
            Console.WriteLine("Vehical Method called");
        }
    }

    public class Car : Vehicle
    {
        public void Printcar(Car obj)
        {
            Console.WriteLine(obj.GetHashCode());
            Console.WriteLine("Car Method called");
        }
    }
    class Contravarience
    {
        
        static void Main()
        {
            Car carobj = new Car();
            carDelegate delobj = carobj.Printcar;
            delobj.Invoke(carobj);

            Vehicle vechicalobj = new Vehicle();
            carDelegate cardel = vechicalobj.Printvechical;
            cardel.Invoke(carobj);

        }
    }

}
*/




