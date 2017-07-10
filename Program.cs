using System;
using System.IO;

namespace Hangman {
  public class Hangman {
    public static void Main(string[] args) {
      var game = new Game("HANG THE MAN");

      while (true) {
        string titleText = File.ReadAllText("title.txt");

        Cell[] title = {
          new Cell(titleText, Cell.CentreAlign)
        };

        string shownWord = game.ShownWord();
        Cell[] word = {
          new Cell(shownWord, Cell.CentreAlign)
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

        char key = Console.ReadKey(true).KeyChar;
        bool wasCorrect = game.GuessLetter(Char.ToUpper(key));
        Console.Clear();
      }
    }
  }
}
