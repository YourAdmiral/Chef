using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Chef.Cultivators
{
    class Cultivator
    {
        public string WriteSort()
        {
            string sort;
            Console.WriteLine("Введите название сорта: ");
            sort = Console.ReadLine();
            return sort;
        }
        public string WriteColor()
        {
            string color;
            Console.WriteLine("Введите цвет: ");
            color = Console.ReadLine();
            return color;
        }
        public double WriteWeight()
        {
            Console.WriteLine("Введите вес (г): ");
            return WriteDouble();
              
        }
        public double WriteProteins()
        {
            Console.WriteLine("Введите количество протеина (г): ");
            return WriteDouble();
        }
        public double WriteFats()
        {
            Console.WriteLine("Введите количество жиров (г): ");
            return WriteDouble();
        }
        public double WriteCarbohydrates()
        {
            Console.WriteLine("Введите количество углеводов (г): ");
            return WriteDouble();
        }
        public double WriteCalories()
        {
            Console.WriteLine("Введите количество калорий (г): ");
            return WriteDouble();
        }
        public double WriteWater()
        {
            Console.WriteLine("Введите количество воды (г): ");
            return WriteDouble();
        }
        public double WriteDouble()
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
