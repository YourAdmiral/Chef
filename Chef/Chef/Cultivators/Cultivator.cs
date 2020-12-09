using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Chef.Cultivators
{
    internal abstract class Cultivator
    {
        private double _weight = -1;
        protected string GetSort()
        {
            Console.WriteLine("---Укажите информацию об ингредиенте---");
            string sort;
            Console.WriteLine("Введите название сорта: ");
            sort = Console.ReadLine();
            return sort;
        }
        protected string GetColor()
        {
            string color;
            Console.WriteLine("Введите цвет: ");
            color = Console.ReadLine();
            return color;
        }
        protected double GetWeight()
        {
            Console.WriteLine("Введите вес (г): ");
            _weight = GetDouble();
            return _weight;

        }
        protected double GetProteins()
        {
            Console.WriteLine("Введите количество протеина (г): ");
            return GetDouble();
        }
        protected double GetFats()
        {
            Console.WriteLine("Введите количество жиров (г): ");
            return GetDouble();
        }
        protected double GetCarbohydrates()
        {
            Console.WriteLine("Введите количество углеводов (г): ");
            return GetDouble();
        }
        protected double GetCalories()
        {
            Console.WriteLine("Введите количество калорий (ккал): ");
            double num = 0;
            while (num == 0)
            {
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());
                    if (num == 0)
                        throw new Exception();
                    if (num < 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    num = 0;
                    Console.WriteLine("Ошибка: Введено некорректное значение!");
                }
            }
            return num;
        }
        protected double GetWater()
        {
            Console.WriteLine("Введите количество воды (г): ");
            return GetDouble();
        }
        protected double GetDouble()
        {
            double num = 0;
            while (num == 0)
            {
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());
                    if (num == 0)
                        throw new Exception();
                    if (num < 0)
                    {
                        throw new Exception();
                    }
                    if (CompareWithWeight(num))
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    num = 0;
                    Console.WriteLine("Ошибка: Введено некорректное значение!");
                }
            }
            return num;
        }
        protected bool CompareWithWeight(double num)
        {
            if (num >= _weight && _weight != -1)
                return true;
            return false;
        }
    }
}
