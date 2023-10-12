using Systems;
using System.IO.Ports;
using System.Threading;

class Program{
    static void Main()
    {
        using(SerialPort serialPort=new SerialPort("COM4",9600))
        {
            try
            {
                serialPort.Open();
                Console.WriteLine("The required serial port is opened and is ready for communication.")

                Thread.Sleep(2000);

                while(true)
                {
                    serialPort.Write("x");
                    Console.WriteLine("Sent:x");
                    Thread.Sleep(2000);

                }
                catch(Exceptioin ex)
                {
                    Console.WriteLine("Error: "+ ex.Message);

                }
                finally
                {
                    if(serialPort.IsOpen)
                    {
                        serialPort.Close();
                        Console.WriteLine("The serial port is now closed, and serial communication is ended.")

                    }
                }
            }
        }
    }
}