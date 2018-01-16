using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static int ReadInt(string s)
        {
            int k;
            bool ok;

            do
            {
                Console.Write("{0}", s);
                ok = Int32.TryParse(Console.ReadLine(), out k);
                if (!ok)
                {
                    Console.WriteLine("Ошибка ввода. Нужно ввести целое число");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (!ok);

            return k;
        }

        static void OutMas(int[] a, int n)
        {
            int i;
            for (i = 0; i < n; i++) Console.Write("{0} ", a[i]);
        }


        static void Main(string[] args)
        {
            int n=ReadInt("Кол-во переменных: ");
            while (n <= 0)
            {
                Console.WriteLine("Ошибка ввода. Нужно ввести целое число больше 0");
                Console.ReadLine();
                Console.Clear();
                n = ReadInt("Кол-во переменных: ");
            }

            Console.Clear();

            int k = Int32.Parse(Math.Pow(2, n).ToString());

            int[] f = new int[k];

            for (int i = 0; i < k; i++)
            {
                f[i] = ReadInt((i + 1) + " значение: ");
                while (f[i] < 0 || f[i]>1)
                {
                    Console.WriteLine("Ошибка ввода. Нужно ввести 1 или 0");
                    Console.ReadLine();
                    Console.Clear();
                    f[i] = ReadInt((i + 1) + " значение: ");
                }
                Console.Clear();
            }

            OutMas(f,k);
            bool ok = true;

            Console.WriteLine();

            Console.Write("Введенная булевая функция принадлежит: ");
            if (f[0]==0) Console.Write("T0 ");
            if (f[k-1] == 1) Console.Write("T1 ");
            for (int i = 0; i < k / 2; i++)
            {
                if (f[i] != f[k - i-1])
                {
                    ok = false;
                    break;
                }
            }
            if (ok) Console.Write("S ");

            Console.ReadLine();

        }
    }
}
