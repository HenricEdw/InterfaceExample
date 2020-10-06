using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMyInterface> myList = new List<IMyInterface>();
            var stringClass = new StringClassTest();
            var anotherClass = new AnotherClass();

            myList.Add(stringClass);
            myList.Add(anotherClass);

            foreach(var item in myList)
            {
                Console.WriteLine(item.GetAString());
                Console.WriteLine(item.GetSum(4.00, 6.00));
            }

            Console.Read();
        }
    }
}
