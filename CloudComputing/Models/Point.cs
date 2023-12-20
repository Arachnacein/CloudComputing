namespace CloudComputing.Models
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public int Id {  get; set; }
        private int _radius;
        public int Radius
        {
            get { return _radius; }
            set
            {
                /*if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(Radius), "Radius cannot be less than 1");*/
                _radius = value;
            }
        }
        public bool IsActive { get; set; }

        public Point(){}
        public Point(double x, double y, int radius, bool isActive)
        {
            X = x;
            Y = y;
            Radius = radius;
            IsActive = isActive;
        }
        public string ToString()
        {
            return "x= "+ X.ToString() + "y="+Y.ToString() + "r="+Radius.ToString() + "id="+Id.ToString();
        }   
    }
}
