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
            Console.WriteLine("---Enter ingredient information---");
            string sort;
            Console.WriteLine("Enter name: ");
            sort = Console.ReadLine();
            return sort;
        }
        protected string GetColor()
        {
            string color;
            Console.WriteLine("Enter color: ");
            color = Console.ReadLine();
            return color;
        }
        protected double GetWeight()
        {
            _weight = -1;
            Console.WriteLine("Enter weight (g): ");
            _weight = GetDouble();
            return _weight;

        }
        protected double GetProteins()
        {
            Console.WriteLine("Enter proteins (g): ");
            return GetDouble();
        }
        protected double GetFats()
        {
            Console.WriteLine("Enter fats (g): ");
            return GetDouble();
        }
        protected double GetCarbohydrates()
        {
            Console.WriteLine("Enter carbohydrates (g): ");
            return GetDouble();
        }
        protected double GetCalories()
        {
            Console.WriteLine("Enter calories (kcal): ");
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
                    Console.WriteLine("Error: Invalid value entered!");
                }
            }
            return num;
        }
        protected double GetWater()
        {
            Console.WriteLine("Enter water amount (g): ");
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
                    Console.WriteLine("Error: Invalid value entered!");
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
