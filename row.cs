using System;

namespace Hangman {
  public class Row {
    public string Text;

    public Row(string text) {
      Text = text;
    }

    public string Draw(int width) {
      return Text;
    }
  }
}
