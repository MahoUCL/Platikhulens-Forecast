using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platikhulens_Forecast
{
    public class Operator
    {

        //Tal fra 90% Rugbrød: 
        public List <int> data = new List<int> {45, 51, 62, 53, 49, 43, 63, 50, 41, 57, 47, 63, 53, 61, 62, 46, 64, 61, 44, 57, 60, 66, 60, 59, 64, 61}; 
        public float total = 0;
        public float avg = 0;
        public float variance = 0;
        public float ialt = 0;
        public float stdDev = 0;
        public List<int> nyData = new List<int>();
        public float upperValue;
        public float lowerValue;
        public float nyAvg;
        public double vastePct = 1.15; //15% spildprocent 
        public int forecast; 


        // Beregn sum og Middelværdien af antal solgte
        public float CalculateAvg()
        {
            foreach (var item in data)
            {
                total += item;
            }
            avg = total / data.Count;
            Console.WriteLine(avg);
            return avg;
        }

        //Beregn varians
        public float CalculateVari()
        {
            foreach(var item in data)
            {
                
                ialt += (item - avg) * (item - avg);
                
            }
            variance = ialt/data.Count; 
            Console.WriteLine(variance);
            return variance;
               
        }

        // Beregn standard afvigelse 
        public float CalculateStdDev()
        {
            stdDev = MathF.Sqrt(variance);
            Console.WriteLine(stdDev);
            return stdDev;

        }

        //Beregn øvre og nedre grænse
        public void CalculateValues()
        {
            //Øvre grænse:
            upperValue = avg + stdDev;

            //Nedre grænse:
            lowerValue = avg - stdDev;

            Console.WriteLine("Øvre grænse: " + upperValue);
            Console.WriteLine("Nedre grænse: " + lowerValue);

            return; 
        }
        
        // Tilføjer tallene i arrayet til en ny liste 
        public void CreateNewListOfNumbers()
        {
            foreach (int number in data)
            {
              if (number <= upperValue && number >= lowerValue)
                {
                    nyData.Add(number);
                }
              
            }
        }

        //Beregne ny middelværdi

        public float CalculateNewAverage()
        {
            //Finder summen af listen
            int sum = 0;
            foreach (int number in nyData)
            {
                sum += number;
            }

            //Beregner ny gennemsnit 

            nyAvg = sum / nyData.Count; 

            Console.WriteLine(nyAvg);
            return nyAvg;

        }

        // Beregner forecast-tallet og afregner til heltal 
        public int ForecastCalculator()
        {
            double forecastNumber;

            forecastNumber = nyAvg * vastePct;

            forecast = (int)Math.Round(forecastNumber); // For at afrunde til korrekt til heltal 

            Console.WriteLine("Forecastet er: " + forecast);
            return forecast;
        }
    }
}

