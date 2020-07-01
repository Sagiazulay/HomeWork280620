using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork280620
{
    class Program
    {
        static void Main(string[] args)
        {
            Game CandyCrash = new Game();

            Game Bubbles = new Game(name: "Bubbles", rating: 5.5f);

            Game Sodoko = new Game(name: "SOdoko", originCountry: "Israel");

            Game Soccer = new Game(name: "Soccer", numberOfPlayers: 11, rating : 5, originCountry: "USA");

            PrintGame(Bubbles);
            PrintGame(Soccer);
        }
        static void PrintGame(Game g)
        {
            Console.WriteLine(g);
            int number = g.TellMeHowManyPlayers();
            if (number > 0)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("There is no more than 0 players");
            }

        }
    }
}
