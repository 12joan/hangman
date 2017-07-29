using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman {
  public class Game {
    public string Word;

    public List<char> GuessedLetters;
    public string Status;
    public int TotalLives;

    public Game(string word) {
      Word = word;
      GuessedLetters = new List<char>();
      Status = "Press any letter to guess!";
      TotalLives = 15;
    }

    public int LivesRemaining() {
      return TotalLives - IncorrectLetters().Length;
    }

    public string ShownWord() {
      var obscuredWord = new StringBuilder();
      foreach (char letter in Word) {
        obscuredWord.Append(ShownLetterFor(letter));
      }
      return obscuredWord.ToString();
    }

    public char[] IncorrectLetters() {
      var incorrectLetters = new List<char>();

      foreach (var letter in GuessedLetters) {
        if (!LetterIsCorrect(letter)) {
          incorrectLetters.Add(letter);
        }
      }

      return incorrectLetters.ToArray();
    }

    public bool GuessLetter(char letter) {
      if (!GuessedLetters.Contains(letter)) {
        GuessedLetters.Add(letter);
      }
      
      bool correct = LetterIsCorrect(letter);
      
      if (correct) {
        Status = "Correct! Guess again!";
      } else {
        Status = "Incorrect! Try again!";
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
