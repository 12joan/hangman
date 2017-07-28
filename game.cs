using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman {
  public class Game {
    public string Word;
    private List<char> GuessedLetters;
    private string StatusMessage;

    public Game(string word) {
      Word = word;
      GuessedLetters = new List<char>();
      StatusMessage = "Press any letter to guess!";
    }

    public string ShownWord() {
      var obscuredWord = new StringBuilder();
      foreach (char letter in Word) {
        obscuredWord.Append(ShownLetterFor(letter));
      }
      return obscuredWord.ToString();
    }

    public string Status() {
      return StatusMessage;
    }
    
    public bool GuessLetter(char letter) {
      GuessedLetters.Add(letter);
      bool correct = LetterIsCorrect(letter);
      
      if (correct) {
        StatusMessage = "Correct! Guess again!";
      } else {
        StatusMessage = "Incorrect! Try again!";
      }

      // CheckGameOver();

      return correct;
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
