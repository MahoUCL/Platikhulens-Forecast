using System.Security.Cryptography.X509Certificates;

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
            Console.ReadLine();
        }
        
            
    }
    
        
        

        
    
}