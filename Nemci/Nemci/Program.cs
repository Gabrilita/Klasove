using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mesec;
            Console.Write("Kolko uchenika: ");
            int n = int.Parse(Console.ReadLine());
            int [] godini = new int [n];


            for (int i = 0; i < n; i++)
            {
                Console.Write("Godini: ");
                godini[i]= int.Parse(Console.ReadLine());
                if (godini[i] == 14)
                {
                    Console.WriteLine("Ti si 8 klas");
                }
                if (godini[i] == 15)
                {
                    Console.WriteLine("Ti si 8 ili 9 klas");
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
                            Console.WriteLine("Ti si 8 klas");
                        }
                        else
                        {
                            Console.WriteLine("Nqma takuv mesec");
                        }
                    }
                    while (mesec > 12 || mesec < 1);
                }


                if (godini[i] == 16)
                {
                    Console.WriteLine("Ti si 9 klas ili 10 klas");
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
                            Console.WriteLine("Ti si 9 klas");
                        }
                        else
                        {
                            Console.WriteLine("Nqma takuv mesec");
                        }
                    }
                    while (mesec > 12 || mesec < 1);
                }
                if (godini[i] == 17)
                {
                    Console.WriteLine("Ti si 10 klas ili 11 klas");
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
                            Console.WriteLine("Ti si 10 klas");
                        }
                        else
                        {
                            Console.WriteLine("Nqma takuv mesec");
                        }
                    }
                    while (mesec > 12 || mesec < 1);
                }
                if (godini[i] == 18)
                {
                    Console.WriteLine("Ti si 11 klas ili 12 klas");
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
                            Console.WriteLine("Ti si 11 klas");
                        }
                        else
                        {
                            Console.WriteLine("Nqma takuv mesec");
                        }
                    }
                    while (mesec > 12 || mesec < 1);
                }
                if (godini[i] == 19)
                {
                    Console.WriteLine("Ti si 12 klas");
                }
                else if (godini[i] < 14 || godini[i] > 19)
                {
                    Console.WriteLine("Ne si vutre");
                }
            }
            Console.WriteLine("---Sort---");
            for (int i = 0; i < godini.Length-1; i++)
            {
                for (int j = 0; j < godini.Length-1; j++)
                {
                    if (godini[j] > godini[j+1])
                    {
                        int c = godini[j];
                        godini[j] = godini[j + 1];
                        godini[j + 1] = c;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(godini[i]+ " ");
            }

        }
    }
}
