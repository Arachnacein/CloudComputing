using CloudComputing.Resources;

namespace CloudComputing.Services
{
    public class FilesReaderService : IFilesReaderService
    {
        private List<Models.Point> Points = new List<Models.Point>();
        public List<Models.Point> ReadData(string fileName)
        { 
            StreamReader reader = new StreamReader(Consts.FilePath + fileName);
            try
            {
                var line = reader.ReadLine();
                line = reader.ReadLine();
                while (line != null)
                {
                    var arr = line.Split(' ');
                    Models.Point newPoint = new Models.Point()
                    {
                        X = Convert.ToDouble(arr[0].Replace(".",",")),
                        Y = Convert.ToDouble(arr[1].Replace(".", ",")),
                        Radius = 0,
                        IsActive = false
                    };
                    Points.Add(newPoint);
                    line = reader.ReadLine();
                }
                reader.Close();
                var sortedPoints = Points.OrderBy(p => p.X).ThenBy(p => p.Y).ToList();
                {
                    int i = 1;
                    foreach (var point in sortedPoints)
                    {
                        point.Id = i;
                        i++;
                    }
                }

                return Points;
            }
            catch (Exception e)
            {
                ///TODO expcetion dialog message
                return new List<Models.Point>();
            }
            finally { reader.Close(); }
        }

        public List<Models.Point> ReadSensorStates(string range, string fileName)
        {
            StreamReader reader = new StreamReader(Consts.FilePath + fileName);
            try
            {
                var line = reader.ReadLine();
                line = reader.ReadLine();
                while (line != null)
                {
                    var arr = line.Split(' ');
                    Models.Point newPoint = new Models.Point()
                    {
                        X = Convert.ToDouble(arr[1].Replace(".", ",")),
                        Y = Convert.ToDouble(arr[2].Replace(".", ",")),
                        Radius = Convert.ToInt32(range),
                        IsActive = Convert.ToInt32(arr[3]) == 0 ? false : true
                    };
                    Points.Add(newPoint);
                    line = reader.ReadLine();
                }
                reader.Close();
                return Points;
            }
            catch (Exception e)
            {
                ///TODO expcetion dialog message
                return new List<Models.Point>();
            }
            finally { reader.Close(); }
        }
    }

    public interface IFilesReaderService
    {
        public List<Models.Point> ReadData(string fileName);
        public List<Models.Point> ReadSensorStates(string range, string fileName);
    }
}
