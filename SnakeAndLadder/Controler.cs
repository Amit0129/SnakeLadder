using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Controler
    {
        public int NoPlay(int position)
        {
            Console.WriteLine( $"The Player position is : {position}");
            return position;
        }
        public int Ladder(int position, int roll)
        {
            position += roll;
            Console.WriteLine("Playear position now is {0}", position);
            return position;
        }
        public int Snake(int position, int roll)
        {
            position -= roll;
            if (position < 0)
            {
                position = 0;
            }
            Console.WriteLine("Playear position now is {0}", position);
            return position;
        }
    }
}
