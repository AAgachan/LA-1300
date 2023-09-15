/* Den Rest des Codes habe ich selber programmiert, jedoch kann es sein, dass es Ähnlichkeiten mit einen Tutorial Video von früeher hat, welches ich im 1sten Schuljahr gesehen habe.
   Jedoch kann ich mich nicht daran erinnern. Aber grundsätzlich kann es kein Plagiat sein.

 */
namespace LA_1300
{
    internal class NumberGenerator
    {
        private Random random;

        public NumberGenerator()
        {
            random = new Random();
        }

        public int Generate(int min, int max)
        {
            return random.Next(min, max + 1);
        }
    }

    internal class ScoreTracker // Das habe ich mit Hilfe von ChatGPT gemacht.
    {
        private List<int> highScores;

        public ScoreTracker()
        {
            highScores = new List<int>();
        }

        public void AddScore(int score)
        {
            highScores.Add(score);
            highScores.Sort();

            if (highScores.Count > 5)
            {
                highScores.RemoveAt(highScores.Count - 1);
            }
        }

        public void Display()
        {
            Console.WriteLine("High Scores:");
            foreach (int score in highScores)
            {
                Console.WriteLine(score);
            }
        }
    }
    public class Game
    {
        private int min = 1;
        private int max;
        private int number;
        private int guess;
        private int guesses;
        private NumberGenerator numberGenerator;
        private ScoreTracker scoreTracker;

        public Game() // Das habe ich mit Hilfe von ChatGPT gemacht.
        {
            numberGenerator = new NumberGenerator();
            scoreTracker = new ScoreTracker();
        }

        public void Play()
        {

            while (true)
            {
                guesses = 0;

                Console.WriteLine("Select game mode:");
                Console.WriteLine("1. Single Player");
                Console.WriteLine("2. Two Player");
                int gameMode = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (gameMode == 1)
                {
                    SinglePlayer();
                }
                else if (gameMode == 2)
                {
                    TwoPlayer();
                }


                DisplayHighScores();
            }
        }

        private void SinglePlayer()
        {
            Console.WriteLine("Choose the range of numbers you would like to guess! ");
            Console.WriteLine("Type the maximum number in: ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            number = numberGenerator.Generate(min, max + 1);
            GuessAndCheck();
        }

        private void TwoPlayer()
        {
            Console.WriteLine("Choose the range of numbers you would like to guess! ");
            Console.WriteLine("Type the maximum number in: ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Choose the number you would like the other player to guess");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            GuessAndCheck();
        }

        private void GuessAndCheck() // Das habe ich mit Hilfe von ChatGPT gemacht.
        {
            Console.WriteLine("Guess the number between {0} and {1}: ", min, max);
            guess = Convert.ToInt32(Console.ReadLine());
            guesses++;

            while (number != guess)
            {
                guesses++;
                if (number < guess)
                {
                    Console.WriteLine("Your guess is higher than the actual number. Try Again! ");
                }
                else
                {
                    Console.WriteLine("Your guess is lower than the actual number. Try Again!");
                }
                guess = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Congratulations! You have guessed the correct number in {0} guesses.", guesses);
            scoreTracker.AddScore(guesses);
        }

        private void DisplayHighScores()
        {
            scoreTracker.Display();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Game game = new Game();
            game.Play();
        }
    }
}