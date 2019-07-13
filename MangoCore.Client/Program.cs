using System;
using System.Threading.Tasks;

namespace MangoCore.Client
{
  class Program
  {
    private static Car car;

    static async Task Main(string[] args)
    {
      initRackSet();
      await demo1();
    }

    private static async Task demo1()
    {
      await car.Goto("L-A1");
    }

    private static void initRackSet()
    {
      car = new Car();

      car.Left = new Rack(8, 14);
      car.Right = new Rack(8, 14);
      car.Home = new Slot();

      for (int row = 0; row < 8; row++)
      {
        for (int col = 0; col < 14; col++)
        {
          car.Left.Slots.Add(new Slot(row, col));
          car.Right.Slots.Add(new Slot(row, col));
        }
      }

      car.StatusChanged += Car_StatusChanged;
    }

    private static void Car_StatusChanged(object sender, StatusChangedEventArgs e)
    {
      Console.WriteLine($"{DateTime.Now:s}: {e.Status} @{e.CurrentSlotNo}");
    }
  }
}
