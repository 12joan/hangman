using System;

namespace Hangman {
  public class Hangman {
    public static void Main(string[] args) {
      var game = new Game("hang the man");
      game.GuessLetter('h');

      var output = game.ShownWord();
      Console.WriteLine(output);

      // Table table = new Table(2, 3);
      // string output = table.Draw();

      // Console.WriteLine(output);
    }
  }
}
