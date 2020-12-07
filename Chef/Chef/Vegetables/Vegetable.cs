using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables
{
    abstract class Vegetable
    {
        protected string sort;
        public string Sort
        {
            get { return sort; }
            set { sort = value; }
        }
        protected string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        protected double weight;
        public double Weight
        {
            get { return weight; }
            set
            {
                if (CheckDouble(value))
                    weight = value;
            }
        }
        protected double proteins;
        public double Proteins
        {
            get { return proteins; }
            set
            {
                if (CheckDouble(value) && CheckWeight(value))
                    proteins = value;
            }
        }
        protected double fats;
        public double Fats
        {
            get { return fats; }
            set
            {
                if (CheckDouble(value) && CheckWeight(value))
                    fats = value;
            }
        }
        protected double carbohydrates;
        public double Carbohydrates
        {
            get { return carbohydrates; }
            set
            {
                if (CheckDouble(value) && CheckWeight(value))
                    carbohydrates = value;
            }
        }
        protected double calories;
        public double Calories
        {
            get { return calories; }
            set
            {
                if (CheckDouble(value) && CheckWeight(value))
                    calories = value;
            }
        }
        protected double water;
        public double Water
        {
            get { return water; }
            set
            {
                if (CheckDouble(value) && CheckWeight(value))
                    water = value;
            }
        }
        public Vegetable(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water)
        {
            this.sort = sort;
            this.color = color;
            this.weight = weight;
            this.proteins = proteins;
            this.fats = fats;
            this.carbohydrates = carbohydrates;
            this.calories = calories;
            this.water = water;
        }
        public virtual void GetInformation()
        {
            Console.WriteLine("---Информация про " + GetVegetableName() + "---");
            Console.WriteLine("Общая информация:\n" +
                "Сорт - " + Sort + ".\n" +
                "Цвет - " + Color + ".\n" +
                "Вес - " + Weight + " г.");
            Console.WriteLine("Пищевая ценность:\n" +
                "Калорийность - " + Calories + " ккал.\n" +
                "Белки - " + Proteins + " г.\n" +
                "Жиры - " + Fats + " г.\n" +
                "Углеводы - " + Carbohydrates + " г.\n" +
                "Вода - " + Water + " г.");
        }
        public virtual void Handle()
        {
            Console.WriteLine("---Подготавливаем " + GetVegetableName() + "---");
            Console.WriteLine("Очистили от пыли и грязи...");
        }
        protected bool CheckDouble(double value)
        {
            try
            {
                if (value.GetType() == typeof(double))
                {
                    if (value > 0)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception("Значение не может быть меньше нуля.");
                    }
                }
                else
                {
                    throw new Exception("Было введено некорректное значение.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                return false;
            }
        }

        protected bool CheckWeight(double value)
        {
            try
            {
                if (value < Weight)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Значение превышает общий вес.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                return false;
            }
        }
        abstract public string GetVegetableName();
    }
}
