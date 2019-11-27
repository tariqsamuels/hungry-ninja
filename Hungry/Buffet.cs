using System;
using System.Collections.Generic;

namespace Hungry 
{
class Buffet
{
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Ribs", 762, true, true),
            new Food("Buffalo Wings", 620, true, false),
            new Food("Banana", 105, true, false),
            new Food("Apple", 95, true, false),
            new Food("Strawberry", 4, true, false),
            new Food("Pineapple", 452, true, false),
            new Food("Kiwi", 42, true, false)
        };
    }
     
    public Food Serve()
    {
        Random rand = new Random();
        int item = (int)rand.Next(7);
        return Menu[item];
    }
}

}