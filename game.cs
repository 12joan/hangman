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

    public string ShownWord() {
      return Word;
    }

    private bool LetterWasGuessed(char letter) {
      return GuessedLetters.Contains(letter);
    }

    private bool LetterIsCorrect(char letter) {
      return Word.Contains(letter);
    }
  }
}
