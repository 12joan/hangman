using System;

namespace Hangman {
  public class Hangman {
    public static void Main(string[] args) {
      // char key = Console.ReadKey(true).KeyChar;

      // var game = new Game("HANG THE MAN");
      // bool wasCorrect = game.GuessLetter(key);
      // Console.WriteLine(wasCorrect.ToString());

      // var output = game.ShownWord();
      // Console.WriteLine(output);

      Table table = new Table(2, 3);
      string output = table.Draw();

      Console.WriteLine(output);
    }
  }
}
