using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> faveFoods = new List<string>() { "pizza", "sushi", "cheesecake", "tacos", "BBQ" };
            Console.WriteLine(faveFoods[0]);
            Console.WriteLine(faveFoods[4]);


            List<int> luckyNums = new List<int>(); //create the list and can add to the list later
            luckyNums.Add(2);
            luckyNums.Add(4);
            luckyNums.Add(24);
            luckyNums.Add(78);

            List<string> faveMovies = new List<string>() { "Baby Driver", "Goodfellas", "Inception", "Jackie Brown", "The Departed" };
            for (int counter = 0; counter < faveMovies.Count; counter++) //.Count represents the length of the list
            {
                Console.WriteLine(faveMovies[counter]);
            }
            faveMovies.Insert(0, "Casino"); //will insert a new element in the list and bump the others down an index
            faveMovies.Insert(3, "Sicario");
            foreach (string film in faveMovies)
            {
                Console.WriteLine(film);
            }
            
            faveMovies.Remove("Inception"); //this is case-sensitive

            foreach (string film in faveMovies)
            {
                Console.WriteLine(film);
            }

            //------ in-class practice ------
            List<string> animals = new List<string>();
            animals.Add("Koala");
            animals.Add("Panda");
            animals.Add("Kangaroo");
            animals.Add("Giraffe");
            animals.Add("Elephant");
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            List<bool> boolList = new List<bool>() { true, false, false, true, false };
            foreach (bool value in boolList)
            {
                if (value == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                }
                else
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }
            }

            List<int> randomNums = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            Console.WriteLine(randomNums.Contains(23));
            Console.WriteLine(randomNums.Contains(77));
            Console.WriteLine(randomNums.Contains(15));

            randomNums.Remove(27);
            randomNums.Remove(77);
            randomNums.Remove(32);
            randomNums.Remove(6);

            Console.WriteLine(randomNums.Contains(23));
            Console.WriteLine(randomNums.Contains(77));
            Console.WriteLine(randomNums.Contains(15));
        }
    }
}
