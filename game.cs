using System;
using System.Collections.Generic;

namespace Hangman {
  public class Game {
    public string Word;
    private List<char> GuessedLetters;

    public Game(string word) {
      Word = word;
      GuessedLetters = new List<char>();
    }
  }
}
