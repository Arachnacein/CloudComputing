using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudComputing.Services
{
    public class GAService
    {
        private List<Models.Point> Sensors { get; set; }
        private List<Models.Poi> Pois { get; set; }
        private List<List<int>> Neighborhood { get; set; }
        private double RequestedCoverage { get; set; }
        private int windowSize { get; set; }
        private bool isDebug1 { get; set; }
        private bool isDebug2 { get; set; }
        private bool isDebug3 { get; set; }

        public GAService(List<Models.Point> sensors, List<Models.Poi> pois, List<List<int>> neighborhood, double requestedCoverage, bool isDebug1, bool isDebug2, bool isDebug3)
        {
            Sensors = sensors;
            Pois = pois;
            Neighborhood = neighborhood;
            RequestedCoverage = requestedCoverage;
            this.isDebug1 = isDebug1;
            this.isDebug2 = isDebug2;
            this.isDebug3 = isDebug3;
        }

        public void calculateFunction1()
        {
            var permutations = generateBinaryPermutations(Sensors.Count);
            var numberPermutations = permutations.Count;
            double currentCoverage = 0;
            int numberOn = 0;

            if (isDebug1)
            {
                foreach (var permutatuion in permutations)
                {
                    
                }
            }
        }

        private double calculateIndividualCoverage(Models.Point point)
        {
            var numbersOfPois = 0;

            foreach (var poi in Pois)
            {
                if (Math.Sqrt(Math.Pow(point.X - poi.X, 2) + Math.Pow(point.Y - poi.Y, 2)) <= point.Radius)
                {
                    numbersOfPois++;
                }
            }
            
            return numbersOfPois/Pois.Count;
        }

        private double calculateAllCoverage()
        {
            return 0;
        }

        private List<string> generateBinaryPermutations(int N)
        {
            List<string> binaryPermutations = new List<string>();
            int totalPermutations = (int)Math.Pow(2, N);

            for (int i = 0; i < totalPermutations; i++)
            {
                string binaryString = Convert.ToString(i, 2).PadLeft(N, '0');
                binaryPermutations.Add(binaryString);
            }

            return binaryPermutations;
        }

    }
}
