using System;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", "damiansoch", true);
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check my new shoes", "damiansoch", "https://imahes.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());
            Console.ReadLine();
        }
    }
}
