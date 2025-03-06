using System;
using System.IO.Ports;
using System.Threading;

class MedicalDeviceMonitor
{
    private SerialPort _serialPort;
    private string _portName;
    private int _baudRate;
    private int _timeout;

    public MedicalDeviceMonitor(string portName, int baudRate = 9600, int timeout = 2000)
    {
        _portName = portName;
        _baudRate = baudRate;
        _timeout = timeout;
    }

    public void Connect()
    {
        try
        {
            _serialPort = new SerialPort(_portName, _baudRate);
            _serialPort.ReadTimeout = _timeout;
            _serialPort.Open();
            Thread.Sleep(2000); // Bağlantının stabil olması için bekleme süresi
            Console.WriteLine("Connected to device.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Connection failed: {e.Message}");
        }
    }

    public string ReadData()
    {
        if (_serialPort != null && _serialPort.IsOpen)
        {
            try
            {
                return _serialPort.ReadLine().Trim();
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Read timeout occurred.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error reading data: {e.Message}");
            }
        }
        return null;
    }

    public void Close()
    {
        if (_serialPort != null && _serialPort.IsOpen)
        {
            _serialPort.Close();
            Console.WriteLine("Connection closed.");
        }
    }
}

class Program
{
    static void Main()
    {
        MedicalDeviceMonitor device = new MedicalDeviceMonitor("COM3"); // Port adını ihtiyacına göre değiştir
        device.Connect();

        for (int i = 0; i < 10; i++)
        {
            string data = device.ReadData();
            if (!string.IsNullOrEmpty(data))
            {
                Console.WriteLine($"Received: {data}");
            }
            Thread.Sleep(1000);
        }

        device.Close();
    }
}
