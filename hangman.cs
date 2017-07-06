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

      var table = new Table(
        Console.WindowWidth,  // width
        2                     // spacing
      );

      var output = table.Draw();

      Console.WriteLine(output);
    }
  }
}
