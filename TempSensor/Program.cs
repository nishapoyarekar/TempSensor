// See https://aka.ms/new-console-template for more information
using TempSensor;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hell oh World!");
        // Create the sensor and monitor
        TemperatureSensor sensor = new TemperatureSensor(30.0f); // Set threshold
        TemperatureMonitor monitor = new TemperatureMonitor();

        // step 5)    Associate the event with the event handler
        sensor.TemperatureExceeded += monitor.OnTemperatureExceeded;

        // Test cases: Any temperature > than 30.0f should trigger an alert
        sensor.UpdateTemperature(25.0f);  // No alert
        sensor.UpdateTemperature(55.0f);  // Alert triggered
    }
}




