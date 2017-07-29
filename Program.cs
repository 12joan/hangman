using System;
using System.IO;

namespace Hangman {
  public class Hangman {
    public static void Main(string[] args) {
      var game = new Game("HANG THE MAN");

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

      object[] titleCell = {titleText, Cell.CentreAlign};
      object[] titleRow = {titleCell}; 

      while (true) {
        string shownWord = game.ShownWord();
        string statusMessage = game.Status();
        char[] rawLetters = game.IncorrectLetters();

        string lettersBlock = String.Format("Incorrect letters:\n {0}",
          String.Join(" ", rawLetters)
        );

        string livesBlock = String.Format("Lives remaining:\n {0}/{0}",
          11,
          15
        );

        object[] wordCell = {shownWord, Cell.CentreAlign};
        object[] wordRow = {wordCell};

        object[] lettersCell = {lettersBlock, Cell.LeftAlign};
        object[] livesCell   = {livesBlock, Cell.RightAlign};
        object[] statsRow = {lettersCell, livesCell};

        object[] statusCell = {statusMessage, Cell.CentreAlign};
        object[] statusRow = {statusCell};

        object[] tableConfig = {
          titleRow,
          wordRow,
          statsRow,
          statusRow
        };

        var table = TableFactory.Build(
          tableConfig, 
          width: width, 
          spacing: spacing
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
