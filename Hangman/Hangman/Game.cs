using System;
using System.Collections.Generic;

namespace Hangman
{
    public class Game
    {
        public List<string> list = new List<string>() { "dog", "cat", "mouse", 
                                                        "giraffe", "elephant" };
        public bool isEnd = false; // trigger for game over

        static void Main(string[] args)
        {
            Game game = new Game();
            Word word = new Word(game);

            Console.WriteLine("Hangman\n");
            Console.WriteLine("Try to guess. What animal am I thinking right now?");

            while (!game.isEnd)
            {
                word.PrintWord();
                word.CheckLetter(Convert.ToChar(Console.Read()));
                Console.ReadKey();
                word.PrintHangman();
                word.IsEnd();
            }
        }
    }
}