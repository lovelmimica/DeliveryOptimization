using GoogleMapsApi.Entities.DistanceMatrix.Request;
using GoogleMapsApi.Entities.DistanceMatrix.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{
    class GoogleDirectionApiClient
    {
        private static string apiKey = "AIzaSyBfcPg5wfaIhcpOdIKJSL0Qg1K-qih6i1E";
        
        public static int RequestDistance(string origin, string destination) 
        {
            DistanceMatrixRequest request = new DistanceMatrixRequest()
            {
                Origins = new string[] { origin },
                Destinations = new string[] { destination },
                ApiKey = apiKey

            };
            DistanceMatrixResponse response = GoogleMapsApi.GoogleMaps.DistanceMatrix.Query(request);
            int distance = response.Rows.ElementAt(0).Elements.ElementAt(0).Distance.Value;

            return distance;
        }
        
    }
}
