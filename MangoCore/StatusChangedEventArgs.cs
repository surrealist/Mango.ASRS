using System;

namespace MangoCore
{
  public class StatusChangedEventArgs : EventArgs
  {

    public StatusChangedEventArgs(CarStatus status, 
        string currentSlotNo)
    {
      Status = status;
      CurrentSlotNo = currentSlotNo;
    }

    public CarStatus Status { get; }
    public string CurrentSlotNo { get; }
     
  }
}