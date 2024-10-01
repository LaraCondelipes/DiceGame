using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace DiceGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Dice Game!!!!");

            Game intialGame = new Game();
            intialGame.PlayerCreater();
            intialGame.Rounds();
           
        }
    }
    public class Game
    {
        string player1;
        string player2;
        int roundsNumber = 1;
        int scorePlayer1 = 0;
        int scorePlayer2 = 0;
        int valuePlayer1;
        int valuePlayer2;

        //Methods
        public void PlayerCreater()
        {
            Console.WriteLine("Introduz o nome do primeiro jogador: ");
            player1 = Console.ReadLine();
            Console.WriteLine("Introduz o nome do segundo jogador: ");
            player2 = Console.ReadLine();

            while (player1 == player2)
            {
                Console.WriteLine("Os nomes não podem ser iguais.");
                Console.WriteLine("Tente novamente :");
                player2 = Console.ReadLine();
            }
        }

        public void Rounds()
        {
            while (roundsNumber < 4 ) //vai ao console fim de jogo e so depois é que faz a 3rodada...
            {
                Console.WriteLine($"Rodada {roundsNumber}");
                ScoreBoard();
                GameStart();
                roundsNumber++;
            }
            

            Console.WriteLine($"Fim do Jogo!!!!");
            if (scorePlayer1 > scorePlayer2)
            {
                Console.WriteLine($"{player1} ganhou o jogo com {scorePlayer1} pontos!");
            }
            else if (scorePlayer2 > scorePlayer1)
            {
                Console.WriteLine($"{player2} ganhou o jogo com {scorePlayer2} pontos!");
            }
            else
            {
                Console.WriteLine("O jogo ficou empatado!");
            }
            
        }

        public void ScoreBoard()
        {
            Console.WriteLine($"Pontuação {player1} : {scorePlayer1}");
            Console.WriteLine($"Pontuaçãp {player2} : {scorePlayer2}");

            if (roundsNumber == 1) 
            {
                Console.WriteLine($"{player1} e {player2} preparados?(Pressionem qualquer tecla)");
                Console.ReadKey();
            }
           
        }

        public void GameStart()
        {
            Console.WriteLine($"{player1} pode lançar o dado! (Pressiona uma tecla.)");
            Console.ReadKey();
            valuePlayer1 = RollDice();
            Console.WriteLine($"{valuePlayer1}");
            Console.WriteLine($"{player2} pode lançar o dado! (Pressiona uma tecla.)");
            Console.ReadKey();
            valuePlayer2 = RollDice();
            Console.WriteLine($"{valuePlayer2}");

            Console.WriteLine($"{player1} tirou o número {valuePlayer1} e {player2} tirou o número {valuePlayer2}. ");

            if (valuePlayer1 > valuePlayer2)
            {
                Console.WriteLine($"{player1} venceu a {roundsNumber}ª rodada.");
                scorePlayer1++;
            }
            else if (valuePlayer2 > valuePlayer1)
            {
                Console.WriteLine($"{player2} venceu a {roundsNumber}ª rodada.");
                scorePlayer2++;
            }
            else
            {
                Console.WriteLine("Empate!!!");
            }
            Console.ReadKey();
        }

        public int RollDice()
        {
            var random = new Random();
            return random.Next(1, 7);
        }
    }

    
}
