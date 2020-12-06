using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Chef.Cultivators
{
    abstract class Cultivator
    {
        protected string WriteSort()
        {
            string sort;
            Console.WriteLine("Введите название сорта: ");
            sort = Console.ReadLine();
            return sort;
        }
        protected string WriteColor()
        {
            string color;
            Console.WriteLine("Введите цвет: ");
            color = Console.ReadLine();
            return color;
        }
        protected double WriteWeight()
        {
            Console.WriteLine("Введите вес (г): ");
            return WriteDouble();
              
        }
        protected double WriteProteins()
        {
            Console.WriteLine("Введите количество протеина (г): ");
            return WriteDouble();
        }
        protected double WriteFats()
        {
            Console.WriteLine("Введите количество жиров (г): ");
            return WriteDouble();
        }
        protected double WriteCarbohydrates()
        {
            Console.WriteLine("Введите количество углеводов (г): ");
            return WriteDouble();
        }
        protected double WriteCalories()
        {
            Console.WriteLine("Введите количество калорий (ккал): ");
            return WriteDouble();
        }
        protected double WriteWater()
        {
            Console.WriteLine("Введите количество воды (г): ");
            return WriteDouble();
        }
        protected double WriteDouble()
        {
            double num = 0;
            while (num == 0)
            {
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());
                    if (num == 0)
                        throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка: Введено некорректное значение!");
                }
            }
            return num;
        }
    }
}
