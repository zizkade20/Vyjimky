
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
            /*
             * TRY-CATCH
            
            Console.WriteLine("Vyberte index záznamu");

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
                    int entry = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(myNumbers[entry]);
                    a = false;
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    a = true;
                }
                catch(FormatException ex) { Console.WriteLine(ex.Message); }

            }
            */

            // VLASTNI VYJIMKA
            Console.WriteLine("Vyberte index záznamu");

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
                    Console.Write("->");
                    int entry = Convert.ToInt32(Console.ReadLine());
                    if (entry >= ind) { throw new CustomException(entry + " je mimo array (" + myNumbers.Length + ")"); }

                    Console.WriteLine(myNumbers[entry-1]);

                }
                catch (CustomException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(FormatException ex) { Console.WriteLine(ex.Message); }

            }
            

        }
    }
    class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {

        }
    }
}