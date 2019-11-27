using System;


namespace Hungry 
{
    class Food 
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet

        public Food(string foodName)
        {
            Name = foodName;
            Calories = 0;
            IsSpicy = false;
            IsSweet = false;
        }
        public Food(string foodName, int cal, bool spicy, bool sweet)
        {
            Name = foodName;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
}