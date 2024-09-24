namespace DiceGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Dice Game!!!!");
            Console.WriteLine("Introduz o nome do primeiro jogador: ");
            var player1 = Console.ReadLine();
            Console.WriteLine("Introduz o nome do segundo jogador: ");
            var player2 = Console.ReadLine();

            if (player1 == player2) 
            {
                Console.WriteLine("Os nomes não podem ser iguais.");

            }
            

        }

    }
    
}
