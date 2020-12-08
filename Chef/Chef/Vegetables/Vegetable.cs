using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables
{
    internal abstract class Vegetable
    {
        private double weight;
        private double proteins;
        private double carbohydrates;
        private double calories;
        private double water;
        private double fats;
        public string Sort { get; set; }
        public string Color { get; set; }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (CheckDouble(value))
                    weight = value;
            }
        }
        public double Proteins
        {
            get { return proteins; }
            set
            {
                if (CheckDouble(value) && CheckWeight(value))
                    proteins = value;
            }
        }
        public double Fats
        {
            get { return fats; }
            set
            {
                if (CheckDouble(value) && CheckWeight(value))
                    fats = value;
            }
        }
        public double Carbohydrates
        {
            get { return carbohydrates; }
            set
            {
                if (CheckDouble(value) && CheckWeight(value))
                    carbohydrates = value;
            }
        }
        public double Calories
        {
            get { return calories; }
            set
            {
                if (CheckDouble(value) && CheckWeight(value))
                    calories = value;
            }
        }
        public double Water
        {
            get { return water; }
            set
            {
                if (CheckDouble(value) && CheckWeight(value))
                    water = value;
            }
        }
        protected Vegetable(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water)
        {
            Sort = sort;
            Color = color;
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
        public abstract string GetVegetableName();
    }
}
