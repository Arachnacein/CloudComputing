using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudComputing.Models
{
    public class Poi
    {
        public double Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Poi(double id, double x, double y)
        {
            Id = id;
            X = x;
            Y = y;
        }
    }
}
