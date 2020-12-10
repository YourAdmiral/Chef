using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Ingredients
{
    internal abstract class Ingredient
    {
        private double _weight;
        private double _proteins;
        private double _carbohydrates;
        private double _calories;
        private double _water;
        private double _fats;
        public string Sort { get; set; }
        public string Color { get; set; }
        public double Weight
        {
            get { return _weight; }
            set
            {
                if (CheckDouble(value))
                    _weight = value;
            }
        }
        public double Proteins
        {
            get { return _proteins; }
            set
            {
                if (CheckDouble(value) && CheckWeight(value))
                    _proteins = value;
            }
        }
        public double Fats
        {
            get { return _fats; }
            set
            {
                if (CheckDouble(value) && CheckWeight(value))
                    _fats = value;
            }
        }
        public double Carbohydrates
        {
            get { return _carbohydrates; }
            set
            {
                if (CheckDouble(value) && CheckWeight(value))
                    _carbohydrates = value;
            }
        }
        public double Calories
        {
            get { return _calories; }
            set
            {
                if (CheckDouble(value) && CheckWeight(value))
                    _calories = value;
            }
        }
        public double Water
        {
            get { return _water; }
            set
            {
                if (CheckDouble(value) && CheckWeight(value))
                    _water = value;
            }
        }
        protected Ingredient(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water)
        {
            Sort = sort;
            Color = color;
            this._weight = weight;
            this._proteins = proteins;
            this._fats = fats;
            this._carbohydrates = carbohydrates;
            this._calories = calories;
            this._water = water;
        }
        public virtual void ShowInformation()
        {
            Console.WriteLine($"---Информация про {GetName()}---\n" +
                $"Общая информация:\n" +
                $"Сорт - {Sort}.\n" +
                $"Цвет - {Color}.\n" +
                $"Вес - {Weight} г.\n" +
                $"Пищевая ценность:\n" +
                $"Калорийность - {Calories} ккал.\n" +
                $"Белки - {Proteins} г.\n" +
                $"Жиры - {Fats} г.\n" +
                $"Углеводы - {Carbohydrates} г.\n" +
                $"Вода - {Water} г.");
        }
        public virtual void Handle()
        {
            Console.WriteLine($"---Подготавливаем {GetName()}---");
        }
        protected bool CheckDouble(double value)
        {
            try
            {
                if (value.GetType() == typeof(double) && value > 0)
                    return true;
                throw new Exception("Было введено некорректное значение.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return false;
            }
        }
        protected bool CheckWeight(double value)
        {
            try
            {
                if (value < Weight)
                    return true;
                throw new Exception("Значение превышает общий вес.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return false;
            }
        }
        public abstract string GetName();
    }
}
