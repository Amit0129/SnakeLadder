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
            Console.WriteLine("No Play");
            Console.WriteLine( $"The Player position is : {position}");
            return position;
        }
        public int Ladder(int position, int roll,int winPosition)
        {
            Console.WriteLine("Ladder");
            position += roll;
            if (position>winPosition)
            {
                position -= roll;
            }
            Console.WriteLine("Playear position now is {0}", position);
            return position;
        }
        public int Snake(int position, int roll)
        {
            Console.WriteLine("Snake");
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
