using System;
using System.Collections.Generic;

namespace Hungry 
{
class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;

    public Ninja()
    {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }
     
     public Boolean IsFull
    {
        get { if(calorieIntake > 1200){
            return true;
            } else {
            return false;
        }
        }
    }
    // build out the Eat method
    public void Eat(Food item)
    {
        if( IsFull == false){
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
            Console.WriteLine($"{item.Name} --- Spicy: {item.IsSpicy}, Sweet: {item.IsSweet}");
        } else {
            Console.WriteLine("Ninja is full!");
        }
    }
}

}