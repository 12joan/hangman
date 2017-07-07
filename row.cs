using System;
using System.Collections.Generic;

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
      var lines = new List<string>();
      for (var i = 0; i < MaxCellDepth(); i++) {
        var line = LineAtIndex(i);
        lines.Add(String.Join("", line));
      }
      return lines.ToArray();
    }

    private string LineAtIndex(int index) {
      var line = new List<string>();
      int usedSpace = 0;
      foreach (var cell in Cells) {
        var part = cell.LineAtIndex(index);

        line.Add(part);
        usedSpace += part.Length;
      }
      return line;
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
