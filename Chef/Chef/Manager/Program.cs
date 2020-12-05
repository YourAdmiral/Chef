using System;

namespace Chef
{
    class Program
    {
        static void Main(string[] args)
        {
            Vegetables.Vegetable vg = new Vegetables.Roots.Potato("Белый сорт", "blue", 100, 8, 7, 10, 2, 15, 100, 200, 300);
            vg.Handle();

        }
    }
}
