using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_with_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] ayu=new string[2][];
            ayu[0] = new string[3];
            ayu[1] = new string[4];

            ayu[0][0] = "Vadodara";
            ayu[0][1] = "Rajkot";
            ayu[0][2] = "Ahemdabad";

            ayu[1][0] = "Gujarat";
            ayu[1][1] = "Madhya Pradesh";
            ayu[1][2] = "Uttar pradesh";
            ayu[1][3] = "Maharastra";

            foreach(var inarray in ayu)
            {
                foreach (var item in inarray)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}
