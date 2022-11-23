namespace SnakeAndLadder
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Game");

            int WIN_POSITION = 100;
            int position = 0;
            int diceCount = 0;
            Console.WriteLine("Playear position now is {0}", position);
            Random random = new Random();

            while (position < WIN_POSITION)
            {
                diceCount++;

                int rollDice = random.Next(1, 7);
                Console.WriteLine($"The value of dice after roll is : {rollDice}");

                int checkOption = random.Next(1, 4);
                Console.WriteLine("Check Option is {0}", checkOption);
                Controler controler = new Controler();

                switch (checkOption)
                {
                    case 1:
                        //controler.NoPlay(position);
                        position = controler.NoPlay(position);

                        break;
                    case 2:
                        //controler.Ladder(position, rollDice);
                        position = controler.Ladder(position, rollDice, WIN_POSITION);
                        break;
                    case 3:
                        //controler.Snake(position, rollDice);
                        position = controler.Snake(position, rollDice);
                        break;
                }
            }
            Console.WriteLine($"Total number of dice played to win is : {diceCount}");
        }
    }
}