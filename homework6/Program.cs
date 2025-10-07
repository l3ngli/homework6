using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Написати програму, яка знаходить середнє арифметичне значення трьох дійсних чисел.
            //перший варіант
            //int a = 5, b = 4, c = 6;
            //int result = (a+b+c)/3;
            //Console.WriteLine(result);

            //другий варіант
            //Console.Write("enter first number: ");
            //string a, b, c;
            //a = Console.ReadLine();
            //Console.Write("enter second number: ");
            //b = Console.ReadLine();
            //Console.Write("enter third number: ");
            //c = Console.ReadLine();
            //int a1 = Int32.Parse(a);
            //int b1 = Int32.Parse(b);
            //int c1 = Int32.Parse(c);
            //int result = (a1 + b1 + c1) / 3;
            //Console.Write("result: " + result);

            //5. Написати програму, яка надає користувачеві можливість ввести з клавіатури кількість гривень, 
            // і переводить цю кількість в долари і євро.
            //Console.WriteLine("how many uah?");
            //string uah;
            //uah = Console.ReadLine();
            //int number = Int32.Parse(uah);
            //double eur = 0.021;
            //Console.WriteLine("uah to eur: " + number*eur);
            //double usd = 0.024;  
            //Console.WriteLine("uah to usd: " + number*usd);

            // 7. Написати програму, яка знаходить відсоток P від числа N.
            //Console.WriteLine("what number?");
            //string n;
            //n = Console.ReadLine();
            //Console.WriteLine("what percent?");
            //string p;
            //p = Console.ReadLine();
            //int percent = Int32.Parse(p);
            //int number = Int32.Parse(n);
            //Console.WriteLine(": " + number*percent/100);

            // 8. Написати програму, яка переводить вказану кількість градусів за Цельсієм в градуси за шкалою Фаренгейта. 
            //Потім реалізувати переклад з градусів за Фаренгейтом в градуси за Цельсієм. *9/5+32
            Console.WriteLine("what number of celsius?");
            string c;
            c = Console.ReadLine();
            int celsius = Int32.Parse(c);
            int c_to_r = celsius * 9 / 5 + 32;
            double r_to_c = (c_to_r - 32) / 1.8;
            Console.WriteLine("celsius to fahrenheit: " + c_to_r);
            Console.WriteLine("fahrenheit to celsius: " + r_to_c);
        }
    }
}
