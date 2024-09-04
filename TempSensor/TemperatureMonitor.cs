using System;


namespace TempSensor
{
    public class TemperatureMonitor
    {
        // step 4)   Create code the will be run when the event occurs (Event Handler)
        public void OnTemperatureExceeded(object sender, TempExceededEventArgs e)
        {
            Console.WriteLine($"Temperature has exceeded! Current Temperature: {e.Temperature}°C");
        }
    }

}
