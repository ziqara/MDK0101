using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практк
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Тип_операции Тип = GetOperation();
            GetMenu(Тип);
        }

        static Тип_операции GetOperation()
        {
            int operation;
            Console.WriteLine("Выберите операцию (1 - расчёт пройденного расстояния, 2 - расчёт ускорения, 3 - расчёт координаты движения, 4 - сохранение результата): ");
            operation = Convert.ToInt32(Console.ReadLine());
            if (operation > 4 && operation < 1)
            {
                return Тип_операции.Нет_операции;
            }
            return (Тип_операции)operation;
        }

        static void GetMenu(Тип_операции Тип)
        {

            switch (Тип)
            {
                case Тип_операции.Расчет_пройденного_расстояния:
                    {
                        Console.WriteLine("Выбрана операция - Расчет пройденного расстояния");
                        Console.WriteLine("Введите скорость: ");
                        double V = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите время: ");
                        double t = Convert.ToDouble(Console.ReadLine());
                        double S = V * t;
                        Console.WriteLine("Расстояние = " + S);
                        break;
                    }
                case Тип_операции.Расчет_ускорения:
                    {
                        Console.WriteLine("Выбрана операция - Расчет ускорения");
                        break;
                    }
                case Тип_операции.Расчет_координаты_движения:
                    {
                        Console.WriteLine("Выбрана операция - Расчет координаты движения");
                        break;
                    }
                case Тип_операции.Нет_операции:
                    {
                        Console.WriteLine("Нет операции.");
                        break;
                    }

            }
        }
    }
}
