
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Vyjimky
{

    class Program
    {
        static void Main()
        {
            bool a = true;
            while (a)
            {
                try
                {
                    int[] myNumbers = { 6, 62, 331 };
                    int ind = 1;
                    foreach (int i in myNumbers)
                    {
                        Console.WriteLine(ind + ") " + i);
                        ind++;
                    }
                    Console.WriteLine("Vyberte index záznamu");
                    int entry = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(myNumbers[entry]);
                    a = false;
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    a = true;
                }
            }
        }
    }
}