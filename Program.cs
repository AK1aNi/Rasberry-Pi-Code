using System.Device.Gpio;
namespace Rasberry_Pi_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GpioController controller = new GpioController(PinNumberingScheme.Board);
            controller.OpenPin(13, PinMode.Output);
            controller.Write(13, PinValue.High);

        }
    }
}
