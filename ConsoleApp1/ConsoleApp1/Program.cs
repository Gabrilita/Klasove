using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mesec;
            Console.Write("Kolko uchenika: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.Write("Godini: ");
                int godini = int.Parse(Console.ReadLine());

                if (godini == 14)
                {
                    Console.WriteLine("Ti si 8 klas");
                }
                if (godini == 15)
                {
                    
                    do
                    {
                        Console.Write("Koi mesec si: ");
                        mesec = int.Parse(Console.ReadLine());
                        if (mesec <= 9 && mesec >= 1)
                        {
                            Console.WriteLine("Ti si 8 klas");
                        }
                        else if (mesec <= 12 && mesec > 9)
                        {
                            Console.WriteLine("Ti si 9 klas");
                        }
                        else
                        {
                            Console.WriteLine("Nqma takuv mesec");
                        }
                    }
                    while (mesec > 12 || mesec < 1);
                }


                if (godini == 16)
                    {
                     
                    do
                    {
                         Console.Write("Koi mesec si: ");
                         mesec = int.Parse(Console.ReadLine());
                         if (mesec <= 9 && mesec >= 1)
                         {
                            Console.WriteLine("Ti si 9 klas");
                         }
                         else if (mesec <= 12 && mesec > 9)
                         {
                            Console.WriteLine("Ti si 10 klas");
                         }
                         else
                         {
                            Console.WriteLine("Nqma takuv mesec");
                         }
                    }
                        while (mesec > 12 || mesec < 1);
                    }
                if (godini == 17)
                {
                  
                    do
                    {
                       Console.Write("Koi mesec si: ");
                       mesec = int.Parse(Console.ReadLine());
                       if (mesec <= 9 && mesec >= 1)
                       {
                          Console.WriteLine("Ti si 10 klas");
                       }
                       else if (mesec <= 12 && mesec > 9)
                       {
                           Console.WriteLine("Ti si 11 klas");
                       }
                       else
                       {
                           Console.WriteLine("Nqma takuv mesec");
                       }
                    }
                        while (mesec > 12 || mesec < 1);
                }
                if (godini == 18)
                {
                   
                    do
                    {
                       Console.Write("Koi mesec si: ");
                       mesec = int.Parse(Console.ReadLine());
                       if (mesec <= 9 && mesec >= 1)
                       {
                           Console.WriteLine("Ti si 11 klas");
                       }
                       else if (mesec <= 12 && mesec > 9)
                       {
                           Console.WriteLine("Ti si 12 klas");
                       }
                       else
                       {
                           Console.WriteLine("Nqma takuv mesec");
                       }
                    }
                        while (mesec > 12 || mesec < 1);
                }
                if (godini == 19)
                {
                   
                    do
                    {
                        Console.Write("Koi mesec si: ");
                        mesec = int.Parse(Console.ReadLine());
                        if (mesec <= 9 && mesec >= 1)
                        {
                            Console.WriteLine("Ti si 12 klas");
                        }
                        else if (mesec <= 12 && mesec > 9)
                        {
                            Console.WriteLine("ti si zavurshil");
                        }
                        else
                        {
                            Console.WriteLine("Nqma takuv mesec");
                        }
                    }
                    while (mesec > 12 || mesec < 1);
                }
                else if (godini < 14 || godini > 19)
                {
                   Console.WriteLine("Ne si vutre");
                }
            }
        }
    }
}
