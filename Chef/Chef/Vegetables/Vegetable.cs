using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables
{
    class Vegetable
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
                try
                {
                    if (value.GetType() == typeof(double))
                    {
                        if (value > 0)
                        {
                            weight = value;
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
                }
            }
        }
        protected double proteins;
        public double Proteins
        {
            get { return proteins; }
            set
            {
                try
                {
                    if (value.GetType() == typeof(double))
                    {
                        if (value < Weight)
                        {
                            proteins = value;
                        }
                        else
                        {
                            throw new Exception("Введенное значение превышает общий вес.");
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
                }
            }
        }
        protected double fats;
        public double Fats
        {
            get { return fats; }
            set 
            {
                try
                {
                    if (value.GetType() == typeof(double))
                    {
                        if (value < Weight)
                        {
                            fats = value;
                        }
                        else
                        {
                            throw new Exception("Введенное значение превышает общий вес.");
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
                }
            }
        }
        protected double carbohydrates;
        public double Carbohydrates
        {
            get { return carbohydrates; }
            set 
            {
                try
                {
                    if (value.GetType() == typeof(double))
                    {
                        if (value < Weight)
                        {
                            carbohydrates = value;
                        }
                        else
                        {
                            throw new Exception("Введенное значение превышает общий вес.");
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
                }
            }
        }
        protected double calories;
        public double Calories
        {
            get { return calories; }
            set 
            {
                try
                {
                    if (value.GetType() == typeof(double))
                    {
                        if (value < Weight)
                        {
                            calories = value;
                        }
                        else
                        {
                            throw new Exception("Введенное значение превышает общий вес.");
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
                }
            }
        }
        protected double water;
        public double Water
        {
            get { return water; }
            set 
            {
                try
                {
                    if (value.GetType() == typeof(double))
                    {
                        if (value < Weight)
                        {
                            water = value;
                        }
                        else
                        {
                            throw new Exception("Введенное значение превышает общий вес.");
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
                }
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
        public void GetInformation()
        {
            Console.WriteLine("Общая информация:\n" +
                "Сорт - " + Sort + ".\n" + 
                "Цвет - " + Color + ".\n" +
                "Вес - " + Weight + ".\n");
            Console.WriteLine("Пищевая ценность:\n" +
                "Калорийность - " + Calories + " ккал.\n" +
                "Белки - " + Proteins + " г.\n" +
                "Жиры - " + Fats + " г.\n" +
                "Углеводы - " + Carbohydrates + " г.\n" +
                "Вода - " + Water + " г.");
        }
        public void Handle()
        {
            Console.WriteLine("Очистили от пыли и грязи...");
        }
    }
}
