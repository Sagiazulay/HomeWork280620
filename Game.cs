using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork280620
{
    public class Game
    {
        public string _name;
        public int _numberOfPlayers;
        public float _rating;
        public string _originCountry;

        public Game()
        {
                
        }
        public Game(string name, float rating)
        {
            _name = name;
            _rating = rating;
        }
        public Game(string name, int numberOfPlayers, float rating, string originCountry)
        {
            _name = name;
            _numberOfPlayers = numberOfPlayers;
            _rating = rating;
            _originCountry = originCountry;
        }
        public Game(string name, string originCountry)
        {
            _name = name;
            _originCountry = originCountry;
        }
        public int TellMeHowManyPlayers()
        {
            return _numberOfPlayers;
        }

        public override string ToString()
        {
            return $"Gamer Name : {_name} Gamer Rating : {_rating} Country : {_originCountry} ";
        }
    }
}
