using System;
using System.Collections;

namespace Hangman {
  public class TableFactory {
    public static Table Build(object[] config) {
      Row[] rows = {
      };
      return new Table(1, 2, rows);
    }
  }
}
