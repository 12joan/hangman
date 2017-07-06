using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman {
  public class Game {
    public string Word;
    private List<char> GuessedLetters;

    public Game(string word) {
      Word = word;
      GuessedLetters = new List<char>();
    }

    public string ShownWord() {
      StringBuilder obscuredWord = new StringBuilder();
      foreach (char letter in Word) {
        obscuredWord.Append(ShownLetterFor(letter));
      }
      return obscuredWord.ToString();
    }
    
    public bool GuessLetter(char letter) {
      GuessedLetters.Add(letter);
      return LetterIsCorrect(letter);
    }

    private char ShownLetterFor(char originalLetter) {
      if (LetterWasGuessed(originalLetter) || originalLetter == ' ') {
        return originalLetter;
      } else {
        return '_';
      } 
    }

    private bool LetterWasGuessed(char letter) {
      return GuessedLetters.Contains(letter);
    }

    private bool LetterIsCorrect(char letter) {
      return Word.Contains(letter.ToString());
    }
  }
}
