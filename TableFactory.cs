using System;
using System.Collections;
using System.Collections.Generic;

namespace Hangman {
  public class TableFactory {
    public static Table Build(object[] config) {
      var rows = new List<Row>();
      foreach (object[] rowConfig in config) {
        rows.Add(BuildRow(rowConfig));
      }
      return new Table(1, 2, rows.ToArray());
    }

    public static Row BuildRow(object[] rowConfig) {
      Cell[] cells = {};
      return new Row(cells);
    }
  }
}
