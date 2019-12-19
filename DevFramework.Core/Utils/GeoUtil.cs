using System.Device.Location;


namespace DevFramework.Core.Infrastructure.Utils
{
    public class GeoUtil
    {
        public static double GetDistance(double fromLat, double fromLong, double toLat, double toLong)
        {
            var toPoint = new GeoCoordinate(toLat, toLong);
            return new GeoCoordinate(fromLat, fromLong).GetDistanceTo(toPoint);
        }
    }
}
