using System.Device.Gpio;
using System.Threading;
namespace Rasberry_Pi_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GpioController controller = new GpioController(PinNumberingScheme.Board);
            int pin = 16;
            int lightTime = 500;

            controller.OpenPin(pin, PinMode.Output);
            Console.Write("On ");
            for (int i =0; i < 10; i++)
            {
                controller.Write(pin, PinValue.High);

                Thread.Sleep(lightTime);
                Console.Write("Off ");
                controller.Write(pin, PinValue.Low);

                Thread.Sleep(lightTime);
            }
        }
    }
}
using System.Device.Gpio;
using System.Threading;


GpioController controller = new GpioController(PinNumberingScheme.Board);
int pin = 16;
int lightTime = 10000;

controller.OpenPin(pin, PinMode.Output);


Console.Write("On ");
controller.Write(pin, PinValue.High);

Thread.Sleep(lightTime);
Console.Write("Off ");
controller.Write(pin, PinValue.Low);

Thread.Sleep(lightTime);

controller.ClosePin(pin);