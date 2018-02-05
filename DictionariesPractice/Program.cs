using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Syntax - dictionary <key data type, value data type? dictionaryName
            //Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            //{
            //    { "Kerry", 90},
            //    { "Barry", 85},
            //    { "Michelle", 100}

            //};

            //Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            //{ 
            //    {"A1", "Sweedish Fish"},
            //    {"A2", "Snickers"},
            //    {"A3", "Sour Patch Kids"},
            //    {"A4", "Funyons" }
            //};

            //// Empty Dictionary ; after parentheses
            //Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //// Using Addmethod, let's add drinks to our drink machine.

            //drinkMachine.Add(10, "Ginger Ale");
            //drinkMachine.Add(11, "Pepsi");
            //drinkMachine.Add(12, "Coke");
            //drinkMachine.Add(13, "Sprite");
            //drinkMachine.Add(14, "Rootbeer");
            //drinkMachine.Add(15, "Water");

            //// Returns size of dictionary
            //Console.WriteLine(drinkMachine.Count);

            //// Prints keys in drinkmachine
            //foreach (KeyValuePair<int, string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Key);
            //}

            //// Prints values in drinkMachine
            //// drink is local to the foreach loop
            //foreach(KeyValuePair<int, string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Value);
            //}

            //// Create a dictionary for a theater coat check with 10 elements
            //// Key will be a numbre, value will be the coat style.
            //// Print all values to console

            Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            {
                {1, "Black Leather Jacket"},
                {2, "Brown Fur Coat" },
                {3, "Red Leather Jacket" },
                {4, "Gold Jacket" },
                {5, "Grey Pea Coat" },
                {6, "Black Pea Coat" },
                {7, "Green winter coat" },
                {8, "Purple Jacket" },
                {9, "Yellow Rain Coat" },
                {10, "Black Leather Jacket" }
            };
            foreach(KeyValuePair<int, string> coat in coatCheck)
            {
                Console.WriteLine(coat.Value);
            }
            Dictionary<string, string> carValet = new Dictionary<string, string>()
            {

                {"Jones", "Honda Civic" },
                {"Lewis", "Chevy Tahoe" },
                {"Riddick", "Ford Mustang" },
                {"Smith", "Dodge Challenger" },
                {"Peterson", "Lexus RX 350" },
                {"Willis", "Nissan Rogue" },
                {"Johnson", "Audi A7" },
                {"Orton", "Ford Explorer" },
                {"Jordan", "Jeep Wrangler" },
                {"James", "Chevy Implala" }
            };

            foreach(KeyValuePair<string, string> name in carValet)
            {
                Console.WriteLine(name.Key);

            }

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>();

            zooAnimals.Add("Zeebra", 4 );
            zooAnimals.Add("Elephant", 6);
            zooAnimals.Add("Lion", 5);
            zooAnimals.Add("Tiger", 8);
            zooAnimals.Add("Bear", 10);
            zooAnimals.Add("Flamingo", 12);
            zooAnimals.Add("Panther", 3);
            zooAnimals.Add("Aligator", 7);
            zooAnimals.Add("Leopard", 8);
            zooAnimals.Add("Lynx", 3);

            int highest = 0;
            foreach (KeyValuePair<string, int> animal in zooAnimals)
            {
                if(animal.Value  > highest)
                {
                    highest = animal.Value;
                }  
            }
            Console.WriteLine(highest);

            foreach(KeyValuePair<string, int> animal in zooAnimals)
            {
                if(animal.Value == highest)
                {
                    Console.WriteLine(animal.Key);
                }
            }
        }
    }
}
