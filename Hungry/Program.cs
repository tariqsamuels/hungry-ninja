using System;

namespace Hungry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Ninja ninja = new Ninja();
            Buffet buffet = new Buffet();
            Console.WriteLine(ninja.IsFull);
            while(ninja.IsFull == false){
                ninja.Eat(buffet.Serve());
            }
            Console.WriteLine(ninja.IsFull);
            foreach(Food item in ninja.FoodHistory){
                Console.WriteLine($"{item.Calories} {item.Name}");
            }
        }
    }
}
