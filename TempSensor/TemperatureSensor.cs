using System;


namespace TempSensor
{
    
    public class TemperatureSensor
    {
        private float _currentTemperature;
        private readonly float _threshold;

        public TemperatureSensor(float threshold)
        {
            _threshold = threshold;
        }

        public event TempExceededEventHandler TemperatureExceeded;
        // step 3)   Declare the code for the event
        protected virtual void OnTemperatureExceeded(TempExceededEventArgs e)
        {
            TemperatureExceeded?.Invoke(this, e);
        }

        public void UpdateTemperature(float newTemperature)
        {
            _currentTemperature = newTemperature;
            if (_currentTemperature > _threshold)
            {
                OnTemperatureExceeded(new TempExceededEventArgs(_currentTemperature));
            }
        }
    }

}
