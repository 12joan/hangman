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
        $"Line {MaxCellDepth()}"
      };
    }

    private int MaxCellDepth() {
      int max = 0;
      foreach (var cell in Cells) {
        max = Math.Max(max, cell.Depth());
      }
      return max;
    }
  }
}
