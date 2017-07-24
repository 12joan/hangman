using System;
using System.IO;

namespace Hangman {
  public class Hangman {
    public static void Main(string[] args) {
      var game = new Game("HANG THE MAN");

      while (true) {
        string titleText = File.ReadAllText("title.txt");
        string shownWord = game.ShownWord();

        object[] titleCell = {titleText, Cell.CentreAlign};
        object[] titleRow = {titleCell}; 

        object[] wordCell = {shownWord, Cell.CentreAlign};
        object[] wordRow = {wordCell};

        object[] lettersCell = {"Incorrect letters:\n A B I U", Cell.LeftAlign};
        object[] livesCell   = {"Lives remaining:\n 11/15",     Cell.RightAlign};
        object[] statsRow = {lettersCell, livesCell};

        object[] statusCell = {"Press any letter to guess!", Cell.CentreAlign};
        object[] statusRow = {statusCell};

        object[] tableConfig = {
          titleRow,
          wordRow,
          statsRow,
          statusRow
        };

        // var table = new Table(                 // Broken
        //   Math.Min(81, Console.WindowWidth),
        //   2,
        //   rows
        // );

        // var tableOutput = table.Draw();

        // Console.WriteLine(tableOutput);

        char key = Console.ReadKey(true).KeyChar;
        bool wasCorrect = game.GuessLetter(Char.ToUpper(key));
        Console.Clear();
      }
    }
  }
}
