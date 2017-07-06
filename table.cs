using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman {
  public class Table {
    public int Width;
    public int Spacing;
    public Row[] Rows;

    public Table(int width, int spacing, Row[] rows) {
      Width = width;
      Spacing = spacing;
      Rows = rows;
    }

    public string Draw() {
      return String.Join("\n", Lines());
    }

    public string[] Lines() {
      List<string> rowTexts = new List<string>();
      foreach (var row in Rows) {
        rowTexts.Add(row.Text);
      }
      return rowTexts.ToArray();
    }
  }
}
