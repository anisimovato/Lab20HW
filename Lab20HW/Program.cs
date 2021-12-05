using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20HW
{
    class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            MyDelegate myDelegate1 = LCircle;
            if (myDelegate1 != null)
            {
                double l = myDelegate1(500);
                Console.WriteLine(l);
            }

            MyDelegate myDelegate2 = SCircle;
            if (myDelegate2 != null)
            {
                double s = myDelegate2(500);
                Console.WriteLine(s);
            }

            MyDelegate myDelegate3 = VCircle;
            if (myDelegate3 != null)
            {
                double v = myDelegate3(500);
                Console.WriteLine(v);
            }
            Console.ReadKey();


        }
        static double LCircle(double R)
        {
            Console.WriteLine("Длина окружности");
            return 2 * Math.PI * R;
        }

        static double SCircle(double R)
        {
            Console.WriteLine("Площадь круга");
            return Math.PI * R * R;
        }

        static double VCircle(double R)
        {
            Console.WriteLine("Объем шара");
            return 4 / 3 * Math.PI * R * R * R;
        }

    }


}
//1.В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
//-метод получает входным параметром переменную типа double;
//-метод возвращает значение типа double, которое является результатом вычисления.

//Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
//-длину окружности по формуле D = 2 * π* R;
//-площадь круга по формуле S = π* R²;
//-объем шара.Формула V = 4 / 3 * π * R³.
//Методы должны быть объявлены как статические.