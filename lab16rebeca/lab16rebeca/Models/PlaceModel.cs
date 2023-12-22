using System;
using System.Collections.Generic;
using System.Text;

namespace lab16rebeca
{
    public class PlaceModel
    {
        public string name {  get; set; }
        public float rating { get; set; }
        public Location location { get; set; }
        public string image_url { get; set; }
        public string date { get; set; }
        public float price { get; set; }
    }

    public class Location
    {
        public string country { get; set; }
        public string city { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}
