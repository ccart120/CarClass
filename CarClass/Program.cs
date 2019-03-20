using System;


namespace CarClass
{
    class Program
    {

        static void Main(string[] args)
        {
            Car car = new Car();
            Random random = new Random();
            double min = 0.0;
            double max = 13.0;
            car.GasLevel = min + random.NextDouble() * (max - min);
             //random.NextDouble(0.0, 13.0) * 0.0;

        }
    }
    class Car
    {
        
        public double GasLevel { get; set; }



        public float AddGas(float currentGasLevel, float addedGasAmount)
        {
        
            return currentGasLevel += addedGasAmount;

        }

        public float FillUp(float addedGasAmount, double max, float currentGasLevel)
        {
            
            float vOut = Convert.ToSingle(max);
            max = Convert.ToSingle(max);
            addedGasAmount = (float)max - currentGasLevel;
            return addedGasAmount;
        }







    }
}
