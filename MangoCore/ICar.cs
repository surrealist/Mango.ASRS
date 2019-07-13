using System;
using System.Threading.Tasks;

namespace MangoCore
{
  public interface ICar
  {
    Rack Left { get; set; }
    Rack Right { get; set; }
    Slot Home { get; set; }

    Task Goto(string slotNo); // L-L5 

    void Load(); // load pallet from the car to current slot.
    void Unload(); // unload pallet from current slot into the car.

    string CurrentPosition { get; } // Home, L-L5
    CarStatus CurrentStatus { get; }

    event EventHandler<StatusChangedEventArgs> StatusChanged;
  }
}
