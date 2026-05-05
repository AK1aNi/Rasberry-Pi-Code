using System.Device.Gpio;
using System.Threading;

GpioController controller = new GpioController(PinNumberingScheme.Board);
int pin = 16;
int lightTime = 5000;

controller.OpenPin(pin, PinMode.Output);
controller.Write(pin, PinValue.High);
controller.OpenPin(21, PinMode.InputPullUp);

while (true)

{



    if (controller.Read(21) == PinValue.Low)

    {

        // Button is pressed (active low) 

        Console.WriteLine("Button pressed");

    }



    Thread.Sleep(500);

}


//GpioController controller = new GpioController(PinNumberingScheme.Board);
//int pin = 16;
//int lightTime = 500;

//controller.OpenPin(pin, PinMode.Output);
//Console.Write("On ");
//for (int i =0; i < 10; i++)
//{
//    controller.Write(pin, PinValue.High);

//    Thread.Sleep(lightTime);
//    Console.Write("Off ");
//    controller.Write(pin, PinValue.Low);

//    Thread.Sleep(lightTime);


