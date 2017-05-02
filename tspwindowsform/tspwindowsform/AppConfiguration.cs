using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{
    class AppConfiguration
    {
        public static string routeImageDirectory = "route-images";

        public static string GetRouteImageDirectory()
        {
            return routeImageDirectory;
        }
    }
}
