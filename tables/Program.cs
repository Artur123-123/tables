using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tables
{
    internal class Program
    {
        class Tablice
        {        
            internal int[] numbers = new int[5];

            internal void wpisywanie()
            {
                for(int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            internal string wypisywanie()
            {
                string napis = "";
                foreach(int w in numbers)
                {
                    napis = w.ToString() + "; ";
                    Console.Write(napis);
                }
                return napis;
            }

            internal int mat(string znak)
            {
                znak = Console.ReadLine();
                int suma = numbers[0];
                if (znak == "+")
                {
                    foreach (int w in numbers)
                    {
                        suma = suma + w;
                    }
                }
                else if (znak == "*")
                {
                    foreach(int w in numbers)
                    {
                        suma *= w;
                    }
                }
                return suma;
            }
        }

        static void Main(string[] args)
        {
            Tablice tablice = new Tablice();
            tablice.wpisywanie();
            tablice.wypisywanie();
            Console.WriteLine(tablice.mat("*"));
        }
    }
}
