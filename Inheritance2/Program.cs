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

            VideoPost videoPost1 = new VideoPost("My new video", "damiansoch", "http://videoURL.com", 10, true);
            Console.WriteLine(videoPost1.ToString());
            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadLine();
        }
    }
}

