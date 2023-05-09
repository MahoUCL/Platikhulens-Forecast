using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platikhulens_Forecast
{
    public class Operator
    {
        public int[] data = { 10, 9, 12, 11, 13, 8, 9, 13 };
        public float total = 0;
        public float avg = 0;
        public float variance = 0;
        public float ialt = 0;
        public float stdDev = 0;

        public float CalculateAvg()
        {
            foreach (var item in data)
            {
                total += item;
                avg = total / data.Length;
            }
            Console.WriteLine(avg);
            return avg;
        }
        public float CalculateVari()
        {
            foreach(var item in data)
            {
                
                ialt += (item - avg) * (item - avg);
                
            }
            variance = ialt/data.Length; 
            Console.WriteLine(variance);
            return variance;
               
        }
        public float CalculateStdDev()
        {
            stdDev = MathF.Sqrt(variance);
            Console.WriteLine(stdDev);
            return stdDev;

        }
        

    }
}
