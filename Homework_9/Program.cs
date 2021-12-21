using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в Калькулятор!");
            int x, y;
            x = y = 0;
            Console.Write("Введите целое число Х:");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка. Недопустимое значение");
                Console.ReadKey();
                return;
            }
            Console.Write("Введите целое число Y:");
            try
            {
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка. Недопустимое значение");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Выберите код операции:");
            Console.WriteLine("        1 - сложение");
            Console.WriteLine("        2 - вычитание");
            Console.WriteLine("        3 - умножение");
            Console.WriteLine("        4 - деление");
            Console.Write("Ваш выбор:");
            int c = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (c)
            {
                case 1:
                    result = x + y;
                    break;
                case 2:
                    result = x - y;
                    break;
                case 3:
                    result = x * y;
                    break;
                case 4:
                    try
                    {
                        result = x / y;
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Ошибка! Нет операции под заданным номером");
                        Console.ReadKey();
                        return;
                    }
            }
            Console.WriteLine("Результат: {0}", result);
            Console.ReadKey();
        }

    }
}
