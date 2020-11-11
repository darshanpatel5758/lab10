using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("What category are you interested in? Please select one of the number:");
                Console.WriteLine("1. Animated");
                Console.WriteLine("2. Drama");
                Console.WriteLine("3. Horror");
                Console.WriteLine("4. Scifi");
                // Tackeing a input from user.
                int userInput = Convert.ToInt32(Console.ReadLine());

                var movies = new List<MovieBase>();

                if (userInput == 1)
                {
                    movies.Add(new Animated("Robert", "Animated"));
                    movies.Add(new Animated("Bahubali", "Animated"));
                    movies.Add(new Animated("Bahubali 2", "Animated"));
                    movies.Add(new Animated("Bahubali 3", "Animated"));
                }
                else if (userInput == 2)
                {
                    movies.Add(new Drama("Pani Pat", "Drama"));
                    movies.Add(new Drama("Tanaji", "Drama"));
                    movies.Add(new Drama("K.G.F", "Drama"));
                    movies.Add(new Drama("Laxmi Bom", "Drama"));
                }
                else if (userInput == 3)
                {
                    movies.Add(new Horror("Pani Pat", "Horror"));
                    movies.Add(new Horror("Tanaji", "Horror"));
                    movies.Add(new Horror("K.G.F", "Horror"));
                    movies.Add(new Horror("Laxmi Bom", "Horror"));
                }
                else if (userInput == 4)
                {
                    movies.Add(new Scifi("Pani Pat", "Scifi"));
                    movies.Add(new Scifi("Tanaji", "Scifi"));
                    movies.Add(new Scifi("K.G.F", "Scifi"));
                    movies.Add(new Scifi("Laxmi Bom", "Scifi"));
                }
                else
                {
                    Console.WriteLine("Sorry wrong input! ");
                    break;
                }

                Console.WriteLine("Continue? (y/n): ");
                String userInput2 = Console.ReadLine();

                if (userInput2.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Bye!");
                    break;
                }


            } while (true);




        }
    }

    public abstract class MovieBase
    {

        public string movieName;
        public string movieCategory;
    }

    public class Animated : MovieBase

    {
        public Animated(string title, string category)
        {
            movieName = title;
            movieCategory = category;
            Console.WriteLine($"{movieName} & {movieCategory}");
        }

    }

    public class Drama : MovieBase
    {
        public Drama(string title, string category)
        {
            movieName = title;
            movieCategory = category;
            Console.WriteLine($"{movieName} & {movieCategory}");
        }
    }
    public class Horror : MovieBase
    {
        public Horror(string title, string category)
        {
            movieName = title;
            movieCategory = category;
            Console.WriteLine($"{movieName} & {movieCategory}");
        }
    }
    public class Scifi : MovieBase
    {
        public Scifi(string title, string category)
        {
            movieName = title;
            movieCategory = category;
            Console.WriteLine($"{movieName} & {movieCategory}");
        }
    }
}
