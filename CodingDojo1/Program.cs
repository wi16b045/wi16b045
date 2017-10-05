using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            int j = 10;
            int xx = 100;

            CustomStack<string> stringStack = new CustomStack<string>();
            string test = stringStack.Pop();
            if(test == null)
            {
                Console.WriteLine("Case 1: Erfolgreich, retourniert null");
            }
            else
            {
                Console.WriteLine("Case 1: Fehler!");
            }
            test = stringStack.Peak();
            if (test == null)
            {
                Console.WriteLine("Case 2: Erfolgreich, retourniert null");
            }
            else
            {
                Console.WriteLine("Case 2: Fehler!");
            }
            stringStack.Push("Test");
            test = stringStack.Peak();
            String test1 = stringStack.Peak();
            if(test != null && test1 != null && test.Equals(test1))
            {
                Console.WriteLine("Case 3: Erfolgreich -> " + test);
            }
            else
            {
                Console.WriteLine("Case 3: Fehler");
            }
            test = stringStack.Pop();
            test1 = stringStack.Peak();
            string test2 = stringStack.Pop();
            if(test != null && string.IsNullOrEmpty(test1) && string.IsNullOrEmpty(test2))
            {
                Console.WriteLine("Case 4: Erfolgreich");
            }
            else
            {
                Console.WriteLine("Case 4: Fehler -> " + test + " -> " + test1 + " -> " + test2);
            }
            stringStack.Push("A");
            stringStack.Push("B");
            stringStack.Push("C");
            Console.WriteLine("Case 5:");
            do
            {
                if(stringStack.Peak() == null)
                {
                    Console.WriteLine("Output: null");
                }
                Console.WriteLine("Output: " + stringStack.Pop());
            }
            while (stringStack.Peak() != null);

            stringStack.Push("D");
            stringStack.Push("E");
            stringStack.Push("F");
            Console.WriteLine("Case 6:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Output: " + stringStack.Peak());
            }

            Console.ReadLine();
        }
    }
}
