using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman {
  public class Game {
    private char[] ForbiddenLetters = {' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
    public int TotalLives = 15;

    public const int Playing  = 0;
    public const int Ended    = 1;
    public int GameState;

    public string Word;
    public List<char> GuessedLetters;
    public string Status;

    public Game(string word) {
      Word = word;
      GuessedLetters = new List<char>();
      Status = "Press any letter to guess!";
      GameState = Playing;
    }

    public bool IsPlaying() {
      return GameState == Playing;
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

    private bool LetterIsGuessable(char letter) {
      return (
        !LetterWasGuessed(letter) &&                    // Letter has not been guessed already
        Array.IndexOf(ForbiddenLetters, letter) == -1   // Letter is not forbidden
      );
    }

    public void GuessLetter(char letter) {
      if (!LetterIsGuessable(letter)) {
        Status = "";
        return;
      }

      GuessedLetters.Add(letter);
      bool correct = LetterIsCorrect(letter);
      
      if (correct) {
        Status = "Correct! Guess again!";
      } else {
        Status = "Incorrect! Try again!";
      }

      CheckGameOver();
    }

    private void CheckGameOver() {
      if (LivesRemaining() == 0) {
        Status = "Game Over!";
        GameState = Ended;
      }

      if (ShownWord() == Word) {
        Status = "You Win!";
        GameState = Ended;
      }
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
