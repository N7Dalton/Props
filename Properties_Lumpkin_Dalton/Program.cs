using System;

namespace Properties_Lumpkin_Dalton
{
    class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car car2 = new car();

            // sets the make and model for both cars
            car1.Make = "Challenger";
            car2.Make = "Ford";
            car1.Model = "Hellcat";
            car2.Model = "F150";

            // I love console.WriteLine :)
            Console.WriteLine($"Your first car was a {car1.Make} and is a {car1.Model}? dope.");
            Console.WriteLine($"Your second car was a{car2.Make} and is a {car2.Model}? dope.");
        }
    }
}
