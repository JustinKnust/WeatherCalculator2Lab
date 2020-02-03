using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Weather Calulator 2 ***");
            Console.WriteLine("Enter the Temperature in Fahrenheit");

            int temperature = int.Parse(Console.ReadLine());
            if (temperature <= 50)
            {
                Console.WriteLine("Enter the Wind Speed in MPH");
                int windspeed = int.Parse(Console.ReadLine());
                double windChill = 37.74
                    + (0.6125 * temperature)
                    - 35.75 * Math.Pow(windspeed, 0.16)
                    + 0.4275 * temperature * Math.Pow(windspeed, 0.16);
                Console.WriteLine("The windchill is " + windChill);
            }
            else _ = (temperature > 50);
            {
                Console.WriteLine("Enter the Relative Humidity");
                int relativeHumidity = int.Parse(Console.ReadLine());
                double heatIndex = 0.5 * (temperature + 61 + ((temperature - 68) * 1.2) + (relativeHumidity * 0.094));
                Console.WriteLine("The Heat Index is " + heatIndex);
            }




        }
    }
}
