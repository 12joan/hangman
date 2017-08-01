using System;
using System.Collections.Generic;

namespace Hangman {
  public class Row {
    public Cell[] Cells;
    private int Width;

    public Row(Cell[] cells) {
      Cells = cells;
    }

    public string Draw(int width) {
      // return new String(' ', width - Text.Length) + Text;
      Width = width;
      return String.Join("\n", Lines());
    }

    private string[] Lines() {
      var lines = new List<string>();
      for (var i = 0; i < MaxCellHeight(); i++) {
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
        var spacing = SpacingFor(cell, usedSpace);
        line.Add(spacing + part);
        usedSpace += part.Length;
      }
      return String.Join("", line);
    }

    private string SpacingFor(Cell cell, int usedSpace) {
      int spaces = cell.LeftMargin(Width) - usedSpace;
      return new String(' ', Math.Max(0, spaces));
    }

    private int MaxCellHeight() {
      int max = 0;
      foreach (var cell in Cells) {
        max = Math.Max(max, cell.Height());
      }
      return max;
    }
  }
}
