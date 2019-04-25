using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Base_Lesson_9.Practice
{
    public static class Practice
    {
        /// <summary>
        /// L9-P-EX-1/2
        /// Создать структуру Coordinates (трехмерных). 
        /// Добавить экземплярный метод деконструкции значений координат.
        /// Вывести на консоль длину вектора по координатам.
        /// </summary>
        public static void L9_P_EX_1_from_2()
        {
            Coordinates vector = new Coordinates(10, 5, 15);
            var (length, _) = vector;
            Console.WriteLine(length);
        }

        /// <summary>
        /// L9-P-EX-2/2. 
        /// Создать деконструктор для обьекта DateTime 
        /// (год, месяц, день, час, минуты, секунды). 
        /// Получить и вывести на консоль текущее время.
        /// Использовать пустые параметры.
        /// </summary>
        public static void L9_P_EX_2_from_2()
        {
            DateTime dateTime = new DateTime();
            var (_, _, _, hour, minute, second) = dateTime;
            Console.Write($"{hour}:{minute}:{second}");
        }
        public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day, out int hours, out int minutes, out int seconds)
        {
            year = DateTime.Now.Year;
            month = DateTime.Now.Month;
            day = DateTime.Now.Day;
            hours = DateTime.Now.Hour;
            minutes = DateTime.Now.Minute;
            seconds = DateTime.Now.Second;
        }
    }

    public struct Coordinates
    {
        public double x, y, z;
        public Coordinates(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void Deconstruct(out double length, out string WhyTwoParams)
        {
            length = Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)), 2);
            WhyTwoParams = "Почему не работает с одним параметром?";

        }

    }

}
