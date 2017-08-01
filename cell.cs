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

    public int LeftMargin(int width) {
      switch (Align) {
        case LeftAlign:
          return 0;
        case CentreAlign:
          return (width - Length()) / 2;
        case RightAlign:
          return width - Length();
        default:
          return -1; // should never reach
      }
    }

    public int Length() {
      int max = 0;
      foreach (var line in Lines()) {
        max = Math.Max(max, line.Length);
      }
      return max;
    }

    public string[] Lines() {
      return Text.Split('\n');
    }

    public string LineAtIndex(int index, string notFound="") {
      if (index < Lines().Length) {
        return Lines()[index];
      } else {
        return notFound;
      }
    }

    public int Height() {
      return Lines().Length;
    }
  }
}
