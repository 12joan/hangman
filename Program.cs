using System;
using System.IO;

namespace Hangman {
  public class Hangman {
    public static void Main(string[] args) {
      var wordGenerator = new RandomWord();
      var word = wordGenerator.Word();
      var game = new Game(word);
      var width = Math.Min(81, Console.WindowWidth);

      string titleText;
      int spacing;
      if (width >= 81) {
        titleText = File.ReadAllText("title_long.txt");
        spacing = 2;
      } else if (width >= 48) {
        titleText = File.ReadAllText("title_short.txt");
        spacing = 1;
      } else {
        titleText = "Hangman";
        spacing = 1;
      }

      while (game.IsPlaying()) {
        var table = HangmanTable.Build(
          word,
          titleText,
          game,
          width,
          spacing
        );

        var tableOutput = table.Draw();
        Console.Clear();
        Console.WriteLine(tableOutput);

        char key = Console.ReadKey(true).KeyChar;
        game.GuessLetter(Char.ToUpper(key));
      }
      // After the game
      Console.Clear();
      Console.WriteLine(game.Status);
      Console.WriteLine("The word was \"{0}\".", word);
    }
  }
}
