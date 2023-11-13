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
                while(line != null)
                {
                    var arr = line.Split(' ');
                    Models.Point newPoint = new Models.Point()
                    {
                        X = Convert.ToInt32(arr[0]),
                        Y = Convert.ToInt32(arr[1]),
                        Radius = Convert.ToInt32(arr[2]),
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
    }
}
