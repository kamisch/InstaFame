﻿using System;
using Plugin.Geolocator;
using Xamarin.Forms.Maps;
using MapKit;
using CoreLocation;


namespace DriveBy.MapThings
{
    public class EnableLocation
    {
        public EnableLocation()
        {
            ViewController vc = new ViewController();
            map = vc.getMap();
            CoreLocation.CLLocationManager locationManager = new CoreLocation.CLLocationManager();
            locationManager.RequestWhenInUseAuthorization();
            map.IsShowingUser = true;
            
            
            
            
            // add an annotation
            /*map.AddAnnotations (new MKPointAnnotation (){
                Title="MyAnnotation",
                Coordinate = new CoreLocation.CLLocationCoordinate2D(42.364260, -71.120824)
            });*/
               
        }
    }
}
}
