using System;


namespace TempSensor
{
    // step 2)   Set up the delegate for the event
    public delegate void TempExceededEventHandler(object sender, TempExceededEventArgs e);
    public class TempExceededEventArgs : EventArgs
    {
        //step 1)   Create a class to pass as an argument for the event handlers (EventArgs class)
        public float Temperature { get; }

        public TempExceededEventArgs(float temperature)
        {
            Temperature = temperature;
        }
       

    }
}
