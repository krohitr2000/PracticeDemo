using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class MultiClass
    {
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public void newClass()
        {
            

            Console.WriteLine("Enter two numbers :");
            int x=int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int result = Multiply(x, y);
            Console.WriteLine("result : "+result);
        }
    }
}
