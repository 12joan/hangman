using System;
using System.IO;

namespace Hangman {
  public class ArgumentWord : IWordable {
    public string Word() {
      return Environment.GetCommandLineArgs()[1].ToUpper();
    }
  }
}
