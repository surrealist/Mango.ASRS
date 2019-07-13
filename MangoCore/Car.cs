using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MangoCore
{
  public class Car : ICar
  {
    public string CurrentPosition { get; set; }

    public CarStatus CurrentStatus { get; set; }

    public Rack Left { get; set; }
    public Rack Right { get; set; }
    public Slot Home { get; set; }

    public event EventHandler<StatusChangedEventArgs> StatusChanged;

    public async Task Goto(string slotNo)
    {
      await Task.Delay(2000);
      StatusChanged?.Invoke(this,
        new StatusChangedEventArgs(CarStatus.Stopped, slotNo));
    }

    public void Load()
    {
      throw new NotImplementedException();
    }

    public void Unload()
    {
      throw new NotImplementedException();
    }


  }
}
