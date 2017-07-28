using System;
using System.Collections;
using System.Collections.Generic;

namespace Hangman {
  public class TableFactory {
    public static Table Build(object[] config, int width, int spacing) {
      var rows = new List<Row>();
      foreach (object[] rowConfig in config) {
        rows.Add(BuildRow(rowConfig));
      }
      return new Table(width, spacing, rows.ToArray());
    }

    public static Row BuildRow(object[] rowConfig) {
      var cells = new List<Cell>();
      foreach (object[] cellConfig in rowConfig) {
        cells.Add(BuildCell(cellConfig));
      }
      return new Row(cells.ToArray());
    }

    public static Cell BuildCell(object[] cellConfig) {
      var text      = (string) cellConfig[0];
      var alignment = (int)    cellConfig[1];
      return new Cell(text, alignment);
    }
  }
}
