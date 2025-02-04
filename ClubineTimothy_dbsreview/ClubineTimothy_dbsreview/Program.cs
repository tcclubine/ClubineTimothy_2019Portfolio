﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_dbsreview
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Timothy Clubine
             WDD229-O 01
             Assignment 3: Database Review
             10/2/2019
             */

            //Instantiate Database
            Database dbs = new Database();
            dbs.Connect();
            bool programLoop = false;
            int i = 0;

            Console.Clear();
            Console.WriteLine(
                "Assignment 3: Database Review\r\n" +
                "*****************************");

            do
            {
                

                do
                {
                    Weather w = new Weather();
                    Console.Write("\r\n");
                    // 1. Prompt the user to enter a city. Ex: Chicago
                    Console.Write("Enter a city to see the current weather: ");
                    string input = Console.ReadLine();
                    // 2. Query the weather table for the latest entry for the entered table.
                    string stm = $"SELECT city, temp, pressure, humidity FROM weather WHERE weather.city = \"{input}\" ORDER BY createdDate DESC LIMIT 1;";
                    w = dbs.Query(w, stm);
                    // 3. If the city exists in the weather table, display the temp, pressure and humidity.
                    if (w.CityName != null)
                    {
                        Console.WriteLine($"\r\n{w.CityName}");
                        Console.WriteLine($"Temp: {w.Temp}°K");
                        Console.WriteLine($"Pressure: {w.Pressure} in");
                        Console.WriteLine($"Humidity: {w.Humidity}%");
                    }
                    // 4. If the city does not exist, display “No Data Available for the selected city”.
                    else
                    {
                        Console.WriteLine($"\r\nNo Data available for {input}.");
                    }


                    i++;
                    
                } while (i <3);

                // Run your program again and query the weather for Orlando.
                if (!programLoop)
                {
                    /*Once your program is running: 
                     ** Google the current weather in Orlando. Write and execute an SQL statement to add Orlando and the associated fields to the weather table. 
                     ** You may NOT need the provided php file depending on how you connect.*/
                    string stm2 = "INSERT INTO weather (createdDate,weather.city, description,temp,pressure,humidity,temp_min,temp_max,windSpeed,windDeg,country,cityId,resultJson) VALUES(NOW(), \"Orlando\", \"Sunny\", 302.039, 29.92, 58, 72, 88, 14, NULL, \"US\", 3897, null); ";
                    dbs.AddWeather(stm2);
                    Console.Write("\r\n");
                    Console.WriteLine(
                        "*******************************\r\n" +
                        "  New Data Added for Orlando!  \r\n" +
                        "*******************************");

                    programLoop = !programLoop;
                }
                else
                {
                    programLoop = !ValidateBool("Would you like to end the program? (y/n)");
                }
                
            } while (programLoop);

            /*To complete this assignment, submit a screen shot of the programming functioning for the city Dallas, Berlin, and Orlando.*/
            dbs.CloseConnection();
            Console.WriteLine("\r\nEnd of Program.");
            Console.ReadLine();
        }
        public static bool ValidateBool(string message)
        {
            bool answer = false;
            string input = null;
            bool needAValidResponse = true;
            Console.Write(message);

            while (needAValidResponse)
            {

                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "yes":
                    case "y":
                        answer = true;
                        needAValidResponse = false;
                        break;

                    case "no":
                    case "n":
                        needAValidResponse = false;
                        break;
                    default:
                        Console.Write("Enter yes or no (y/n):");

                        break;
                }

            }
            return answer;
        }
    }
}

