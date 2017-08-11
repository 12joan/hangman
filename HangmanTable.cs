using System;
using System.IO;

namespace Hangman {
  public class HangmanTable {
    public static Table Build(string word, string title, Game game, int width, int spacing) {
      object[] titleCell = {title, Cell.CentreAlign};
      object[] titleRow = {titleCell}; 

      string shownWord = game.ShownWord();
      string statusMessage = game.Status;
      char[] rawLetters = game.IncorrectLetters();
      int livesRemaining = game.LivesRemaining();
      int totalLives = game.TotalLives;

      string lettersBlock = String.Format("Incorrect letters:\n {0}",
        String.Join(" ", rawLetters)
      );

      string livesBlock = String.Format("Lives remaining:\n {0}/{1}",
        livesRemaining,
        totalLives
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

      return table;
    }
  }
}
