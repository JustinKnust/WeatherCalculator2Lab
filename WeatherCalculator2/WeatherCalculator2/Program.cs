﻿using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2");

            int temperature;
            int windSpeed;
            double windChill;
            string input = "";
           double heatIndex;
            int relHumidity;

            // Get the temperature from the user
            Console.WriteLine("Enter the temperature");
            input = Console.ReadLine();

            Console.WriteLine("Enter the relative humidity");
            input = Console.ReadLine();

            Console.WriteLine("Enter the wind speed");
            string enteredtemp = Console.ReadLine();

            temperature = int.Parse(input);
            if (temperature > 50)
            {
                heatIndex = .5 * (temperature + 61.0 + ((temperature - 6.08) * 1.2) + (relHumidity * 0.094));
                Console.WriteLine("The heat index is" + heatIndex);
            }
            else (temperature < 50)
            {
                windSpeed = int.Parse(input);
                windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                Console.WriteLine("The wind chill is " + windChill);

            }
            // Get the windspeed from the user
            

            

        }
    }
}
