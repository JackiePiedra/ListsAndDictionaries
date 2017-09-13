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

            Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            {
                { 22, "yellow jacket" },
                { 24,"blue blazer" },
                { 54, "tan trench" },
                { 65, "red bomber" },
                {81, "cardigan" },
                {83, "peacoat" }
            };

            foreach (KeyValuePair<int, string> coat in coatCheck)
            {
                Console.WriteLine(coat);
            }
            Console.WriteLine(coatCheck.Count);

            //foreach (KeyValuePair<int, string> coat in coatCheck)
            //{
            //    Console.WriteLine(coatCheck.Value); //pulls just the value in the pair
            //}

            // ------- in class work --------
            //create a dictionary for a car valet service with 10 cars - key customer last name, value car make, print
            Dictionary<string, string> carValet = new Dictionary<string, string>()
            {
                {"Piedra","Mercedes" },
                {"Smith","BMW" },
                {"Lopez","Audi" },
                {"Jones","Range Rover" },
                {"Rivera","Tesla" },
                {"Johnson","Acura" },
                {"Martinez","Lexus" },
                {"Parker","Subaru" },
                {"Ruiz","Volkswagen" },
                {"Lee","Toyota" }
            };

            foreach (KeyValuePair<string, string> car in carValet)
            {
                Console.WriteLine(car);
            }

            //create dictionary of 10 zoo animals. key animal type, value # of animals at zoo
            //remove animal with lowest # from dictionary using remove method
            //use count property to count the number of remaining animals in dictionary, print
            Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
            {
                {"giraffe", 5 },
                {"elephants", 2 },
                {"lions",10 },
                {"bears", 4 },
                {"monkeys", 12 },
                {"koalas", 14 },
                {"tigers", 6 },
                {"gorilla",3 },
                {"prairie dogs", 24 },
                {"chickens", 18 }

            };
            zooAnimals.Remove("elephants");
            zooAnimals.Remove("gorilla");
            zooAnimals.Remove("bears");
            Console.WriteLine(zooAnimals.Count);

            //create a program that allows a user to input an animal name to check to see if dictionary contains animal name
            //if animal doesnt exist in dictionary, ask user if s/he would like to add it. if so, add to dictionary
            Console.WriteLine("Enter an animal to see if it's part of the dictionary:");
            string userAnimal = Console.ReadLine();

            if(zooAnimals.ContainsKey(userAnimal))
            {
                Console.WriteLine("We have that animal");
            }
            else
            {
                Console.WriteLine("We don't have that animal, do you want to add it to the zoo? Yes or No");
                string yesOrNo = Console.ReadLine();
                if(yesOrNo =="Yes")
                {
                    zooAnimals.Add(userAnimal, 4);
                }
                else
                {
                    Console.WriteLine("Can't find any of those!");
                }
            }

        }
    }
}
