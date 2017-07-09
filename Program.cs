using System;
using System.IO;

namespace Hangman {
  public class Hangman {
    public static void Main(string[] args) {
      char key = Console.ReadKey(true).KeyChar;

      var game = new Game("HANG THE MAN");
      bool wasCorrect = game.GuessLetter(key);
      Console.WriteLine(wasCorrect.ToString());

      var output = game.ShownWord();
      Console.WriteLine(output);

      string titleText = File.ReadAllText("title.txt");

      Cell[] title = {
        new Cell(titleText, Cell.CentreAlign)
      };

      Cell[] word = {
        new Cell("_E__O _O___", Cell.CentreAlign)
      };

      Cell[] stats = {
        new Cell("Incorrect letters:\n A B I U"),
        new Cell("Lives remaining:\n 11/15", Cell.RightAlign)
      };

      Cell[] status = {
        new Cell("Press any letter to guess!", Cell.CentreAlign)
      };

      Row[] rows = {
        new Row(title),
        new Row(word),
        new Row(stats),
        new Row(status)
      };

      var table = new Table(
        Math.Min(81, Console.WindowWidth),
        2,
        rows
      );

      var tableOutput = table.Draw();

      Console.WriteLine(tableOutput);
    }
  }
}
