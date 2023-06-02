using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Branch is final
            Console.WriteLine("Введите а");
            double a= int.Parse(Console.ReadLine());
            Console.WriteLine("Введите а");
            double b= int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите действие:\n1. Складывание\n2. Вычитание\n3. Умножение\n Деление");
            int select=int.Parse(Console.ReadLine());
            switch (select) 
            {
                case 1:
                    Console.WriteLine(a+b);
                    break;

                case 2:
                    Console.WriteLine(a-b);
                    break;
                case 3:
                    Console.WriteLine(a*b);
                    break;

                case 4:
                    Console.WriteLine(a/b);
                    break;
            }
        }
    }
}
