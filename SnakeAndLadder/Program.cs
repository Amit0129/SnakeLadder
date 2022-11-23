namespace SnakeAndLadder
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Game");

            const int WIN_POSITION = 100;
            int playerOnePosi = 0;
            int playerTwoPosi = 0;
            int diceCountPlayOne = 0;
            int diceCountPlayTwo = 0;

            bool player1 = true;
            bool player2 = false;

            Controler controler = new Controler();
            //Console.WriteLine("Playear position now is {0}", position);
            Random random = new Random();
            while (playerOnePosi < WIN_POSITION && playerTwoPosi < WIN_POSITION)
            {
                
                if (player1)
                {
                    Console.WriteLine("Player One Playing");
                    Console.WriteLine();
                    diceCountPlayOne++;

                    int rollDice = random.Next(1, 7);
                    Console.WriteLine($"The value of dice after roll is : {rollDice}");

                    int checkOption = random.Next(1, 4);
                    Console.WriteLine("Check Option is {0}", checkOption);
                    

                    if (checkOption == 1)
                    {
                        //controler.NoPlay(position);
                        playerOnePosi = controler.NoPlay(playerOnePosi);
                        player1 = false;
                        player2 = true;
                    }
                    else if (checkOption == 2)
                    {
                        //controler.Ladder(position, rollDice);
                        playerOnePosi = controler.Ladder(playerOnePosi, rollDice, WIN_POSITION);
                    }
                    else
                    { //controler.Snake(position, rollDice);
                        playerOnePosi = controler.Snake(playerOnePosi, rollDice);
                        player1 = false;
                        player2 = true;
                        
                    }
                }
                else
                {
                    Console.WriteLine("Player Two Playing");
                    Console.WriteLine();
                    diceCountPlayTwo++;

                    int rollDice = random.Next(1, 7);
                    Console.WriteLine($"The value of dice after roll is : {rollDice}");

                    int checkOption = random.Next(1, 4);
                    Console.WriteLine("Check Option is {0}", checkOption);


                    if (checkOption == 1)
                    {
                        //controler.NoPlay(position);
                        playerTwoPosi = controler.NoPlay(playerTwoPosi);
                        player1 = true;
                        player2 = false;
                    }
                    else if (checkOption == 2)
                    {
                        //controler.Ladder(position, rollDice);
                        playerTwoPosi = controler.Ladder(playerTwoPosi, rollDice, WIN_POSITION);
                    }
                    else
                    { //controler.Snake(position, rollDice);
                        playerTwoPosi = controler.Snake(playerTwoPosi, rollDice);
                        player1 = true;
                        player2 = false;
                        
                    }
                }
                


            }
            if (playerOnePosi == WIN_POSITION)
            {
                Console.WriteLine("Player One Win");
                Console.WriteLine($"Total number of dice played by player 1 to win is : {diceCountPlayOne}");
            }
            if (playerTwoPosi == WIN_POSITION)
            {
                Console.WriteLine("Player Two Win");
                Console.WriteLine($"Total number of dice played by player 2 to win is : {diceCountPlayTwo}");
            }
        }
    }
}