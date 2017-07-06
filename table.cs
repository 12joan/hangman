using System;

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
      return "Hello World";
    }
  }
}
