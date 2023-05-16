

namespace Platikhulens_Forecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operator Math = new Operator();
            Math.CalculateAvg();
            Math.CalculateVari();
            Math.CalculateStdDev();
            Math.CalculateValues();
            Math.CreateNewListOfNumbers();
            Math.CalculateNewAverage();



            Math.ForecastCalculator(); 

            Console.ReadLine();

        }
        
            
    }
    
        
        

        
    
}