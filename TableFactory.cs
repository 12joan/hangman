using System;
using System.Collections;

namespace Hangman {
  public class TableFactory {
    public static Table Build(Hashtable config) {
      Row[] rows = {
      };
      return new Table(1, 2, rows);
    }
  }
}
