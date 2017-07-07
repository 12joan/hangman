using System;

namespace Hangman {
  public class Cell {
    public const int RightAlign  = 0;
    public const int CentreAlign = 1;
    public const int LeftAlign   = 2;

    public string Text;
    public int Align;

    public Cell(string text) {
      Text = text;
      Align = LeftAlign;
    }

    public Cell(string text, int align) {
      Text = text;
      Align = align;
    }

    public string[] Lines() {
      return Text.Split('\n');
    }
  }
}
