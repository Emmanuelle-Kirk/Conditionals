using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static int score = 0;
        static int lives = 3;
        static bool oneUpGained = false; // = true or false statement
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");

            score = score + 1000;

            if(oneUpGained == false)
            {
                if (score >= 1000);
                oneUpGained = true;
            }

            if (score >= 1000)
            {
                lives = lives + 1; //1UP
            }
            ShowHUD();

            Console.ReadKey(true);
        }
        static void ShowHUD()
        {
            Console.WriteLine("=========");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("=========");
            Console.WriteLine();
        }

    }
}
