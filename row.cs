using System;

namespace Hangman {
  public class Row {
    public Cell[] Cells;

    public Row(Cell[] cells) {
      Cells = cells;
    }

    public string Draw(int width) {
      // return new String(' ', width - Text.Length) + Text;
      return String.Join("\n", Lines());
    }

    private string[] Lines() {
      return new string[] {
        "Line 1",
        "Line 2"
      };
    }
  }
}
