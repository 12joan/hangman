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
      return String.Join(Separator(), RowStrings());
    }

    private string Separator() {
      return new String('\n', Spacing + 1);
    }

    private string[] RowStrings() {
      var rowTexts = new List<string>();
      foreach (var row in Rows) {
        rowTexts.Add(DrawRow(row));
      }
      return rowTexts.ToArray();
    }

    private string DrawRow(Row row) {
      return row.Draw(Width);
    }
  }
}
