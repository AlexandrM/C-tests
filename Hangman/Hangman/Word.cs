using System;
namespace Hangman
{
    public class Word
    {
        private Random rnd = new Random();
        private string rndWord; // Random Word
        private char[] arrayWord; // array Random Word
        private char[] arrayGuess; // array Guess Word 
        private char[] hangman = { 'H', 'a', 'n', 'g', 'm', 'a', 'n' };
        private int hangmanCount = 0; // count wrong letters
        private int winCount = 0; // count right letters 
        private Game game;

        public Word(Game game)
        {
            this.game = game;
            rndWord = game.list[rnd.Next(5)];
            arrayWord = new char [rndWord.Length];
            for(int i = 0; i < rndWord.Length; i++)
            {
                arrayWord[i] = '*';
            }
            arrayGuess = rndWord.ToCharArray();
        }

        /* Method print guess word */
        public void PrintWord()
        {
            for(int i = 0; i < arrayWord.Length; i++)
            {
                Console.Write(arrayWord[i]);
            }
            Console.WriteLine();
        }

        /* Method print Hangman */
        public void PrintHangman()
        {
            for(int i = 0; i < hangmanCount; i++)
            {
                Console.Write(hangman[i]);
            }
            Console.WriteLine();
        }

        /* Method recieve a char and check letter in word */
        public void CheckLetter(char letter)
        {
            bool result = false;
            for(int i = 0; i < arrayGuess.Length; i++)
            {
                if(letter.Equals(arrayGuess[i])) {
                    arrayWord[i] = letter;
                    winCount++;
                    result = true;
                }
            }
            if (result == true)
            {
                Console.WriteLine("OKIS");
            }
            else
            {
                Console.WriteLine("WRONG!");
                hangmanCount++;
            }
        }

        /* Method check game over */
        public void IsEnd()
        {
            if(winCount == rndWord.Length)
            {
                Console.WriteLine("Yes, I love " + rndWord);
                Console.WriteLine("YOU ARE WINNER");
                game.isEnd = true;
            } 
            if(hangmanCount == 7) 
            {
                Console.WriteLine("YOU ARE LOOOOOOSER");
                game.isEnd = true;
            }
        }
    }
}