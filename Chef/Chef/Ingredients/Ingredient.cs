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
            Console.WriteLine($"---Information about {GetName()}---\n" +
                $"General information:\n" +
                $"Sort - {Sort}.\n" +
                $"Color - {Color}.\n" +
                $"Weight - {Weight} г.\n" +
                $"The nutritional value:\n" +
                $"Calories - {Calories} ккал.\n" +
                $"Proteins - {Proteins} г.\n" +
                $"Fats - {Fats} г.\n" +
                $"Carbohydrates - {Carbohydrates} г.\n" +
                $"Water - {Water} г.");
        }
        public virtual void Handle()
        {
            Console.WriteLine($"---Preparing {GetName()}---");
        }
        protected bool CheckDouble(double value)
        {
            try
            {
                if (value.GetType() == typeof(double) && value > 0)
                    return true;
                throw new Exception("Incorrect value was entered.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
        protected bool CheckWeight(double value)
        {
            try
            {
                if (value < Weight)
                    return true;
                throw new Exception("The value exceeds the total weight.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
        public abstract string GetName();
    }
}
