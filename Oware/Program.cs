/* This is an almost-complete translation of https://github.com/haarismemon/oware/ from Java to C#
*/
using System;

namespace Oware
{
    class Program
    {
        static void Main(string[] args)
        {
            IScoreHouse[] scoreHouses = new IScoreHouse[2];
            Player one = new Player("Player 1", scoreHouses[0]);
            Player two = new Player("Player 2", scoreHouses[1]);
            Board b = new Board(one, two);
            // rest left as exercise to reader!
        }
    }
}
