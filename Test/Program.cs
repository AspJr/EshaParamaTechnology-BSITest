using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string ulang;

            try
            {
                Console.WriteLine("============== KETERANGAN ==============");
                Console.WriteLine("Soal 1 : Ketik 1, Soal 2 : Ketik 2");
                Console.WriteLine("========================================");
                Console.WriteLine();
                Console.Write("Pilih soal : ");
                string input = Console.ReadLine();

                if (input == "1") {
                    Console.Write("Masukkan inputan : ");
                    string input1 = Console.ReadLine();
                    Soal1(input1);
                }
                else if(input == "2"){
                    Console.Write("Masukkan inputan : ");
                    string input2 = Console.ReadLine();
                    Soal2(input2);
                }

                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
            Console.Write("\nStart again (yes or no) ? ");
            ulang = Console.ReadLine();
            if (ulang == "no")
            {
                Environment.Exit(0);
            }
            Console.Write("\n");
            Main(args);
        }


        static void Soal1(string _input)
        {
            int i = 0;
            int[] num;
            num = _input.Split(',').Select(int.Parse).ToArray();
            
            Array.Sort(num);
            Array.Reverse(num);
            Console.WriteLine("Hasil : ");

            for (i = 0; i < num.Length; i++)
            {
                if (num[i] != 7)
                {
                    if (num[i] % 2 != 0)
                    {
                        Console.Write(num[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }


        static void Soal2(string _input)
        {
            int counter = 1;
            char last = '-';
            foreach (char c in _input)
            {
                if (c == last)
                {
                    counter += 1;
                }
                else
                {
                    if (last != '-')
                    {
                        Console.WriteLine(last + " = " + counter);
                    }
                    counter = 1;
                }
                last = c;
            }
            Console.WriteLine(last + " = " + counter);
        }
    }
}
