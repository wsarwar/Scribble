﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scribble
{
    class Program
    {
        static void Main(string[] args)
        {
            RunStopwatch();
            //RunStackOverflowPost();

            Console.ReadLine();
        }

        private static void RunStackOverflowPost()
        {
            var post = new Post("Writing OOP Classes","We are trying to understand the real value of OOP classes");
            
            Console.WriteLine("Votes received:" + post.Votes);
            post.UpVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.UpVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.UpVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.UpVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.DownVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.DownVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.DownVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.DownVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.DownVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.DownVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.DownVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.DownVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.DownVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.DownVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.DownVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.DownVote();
            Console.WriteLine("Votes received:" + post.Votes);
            post.DownVote();
            Console.WriteLine("====================");
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine(post.Created);

            }

        private static void RunStopwatch()
        {
            Console.WriteLine("click a key to start");

            ConsoleKeyInfo quit = Console.ReadKey();

            while (quit.KeyChar != 'q')
            {
                Stopwatch sw = new Stopwatch();
                Console.WriteLine("Started - press Enter to stop");
                sw.Start();
                Console.ReadKey();sw.Stop();
                Console.WriteLine("Stopped");
                Console.WriteLine(sw.Duration);
                Console.WriteLine("Press 'Enter' to start a new stopwatch or press 'q' to quit");
                quit = Console.ReadKey();
            }
        }
    }
}
