namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Game");

            int position = 0;
            Console.WriteLine("Playear position now is {0}",position);

            Random random = new Random();
            int rollDice = random.Next(1, 7);
            Console.WriteLine($"The value of dice after roll is : {rollDice}");
        }
    }
}