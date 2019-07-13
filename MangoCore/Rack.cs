using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MangoCore
{
  public class Rack
  {

    public Rack(int rows, int columns)
    {
      Columns = columns;
      Rows = rows;
      Slots = new HashSet<Slot>(); 
    }
     
    [Key]
    public string Code { get; set; }

    public int Columns { get;  }
    public int Rows { get;  }
    public ICollection<Slot> Slots { get; set; }

  }
}
