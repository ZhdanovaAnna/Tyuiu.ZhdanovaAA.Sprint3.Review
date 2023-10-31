using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhdanovaAA.Sprint3.TaskReview.V14.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint3.TaskReview.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Жданова А. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: SprintReview                                                      *");
            Console.WriteLine("* Задание: TaskReview                                                     *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Жданова Анна Александровна                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции (произвести*");
            Console.WriteLine("* табулирование) f(x) = 2x - 4 + (2x - 1)/(sin(x) + 1) на заданном        *");
            Console.WriteLine("* диапозоне [-5; 5] с шагом 1. Произвести проверку деления на ноль. При   *");
            Console.WriteLine("* делении на ноль вернуть значение 0. Значения округлить до двух знаков   *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5, stopValue = 5;
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-------------+-------------+");
            Console.WriteLine("|      X      |     f(x)    |");
            Console.WriteLine("+-------------+-------------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("| {0,6:d}      |   {1,6:f2}    |", startValue, valueArray[i]);
                startValue++;
            }

            Console.WriteLine("+-------------+-------------+");
            Console.ReadKey();
        }
    }
}
