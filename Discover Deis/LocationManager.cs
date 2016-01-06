using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls.Maps;

namespace Discover_Deis
{
    public class LocationManager
    {
        public static Geoposition currentPosition;

        public async static Task<Geoposition> GetPosition()
        {
            var accessStatus = await Geolocator.RequestAccessAsync();

            if (accessStatus != GeolocationAccessStatus.Allowed) throw new Exception();

            var geolocator = new Geolocator { DesiredAccuracyInMeters = 0 };
            var position = await geolocator.GetGeopositionAsync();

            return position;
        }


        public static async void CenterMapOnCurrent(MapControl m)
        {
            currentPosition = await GetPosition();
            m.Center = currentPosition.Coordinate.Point;
            m.ZoomLevel = 12;
            m.LandmarksVisible = true;
        }
    }
}
