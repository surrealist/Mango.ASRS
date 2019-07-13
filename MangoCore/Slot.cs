using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MangoCore
{
  public class Slot
  {

    public Slot()
    {
      Row = Column = -1;
      Code = "Home";
      IsEmpty = true;
    }

    public Slot(int row, int col)
    {
      Row = row;
      Col = col;
      Code = ((int)'A' + col).ToString() + row;
      IsEmpty = true;
    }

    [Key]
    public string Code { get; set; }

    // 0 is A, 1 is B, ...
    public int Column { get; set; }

    // C5    // Column = 2    // Row = 6
    public int Row { get; set; }
    public int Col { get; }
    public bool IsEmpty { get; set; }

    public string ItemCode { get; set; }
    public int? Quantity { get; set; }
    public DateTime? StoreDate { get; set; }

  }
}
