using System;
using System.IO;

namespace Hangman {
  public class RandomWord : IWordable {
    public string Word() {
      return RawWords();
    }

    private string RawWords() {
      return File.ReadAllText("words.txt");
    }
  }
}
