using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{
    class TripPlan : IDirection
    {
        public List<Route> RouteList { get;  }

        public void AddRoute(Route r)
        {
            RouteList.Add(r);
        }

        public TripPlan()
        {
            RouteList = new List<Route>();
        }
        public TripPlan(List<Route> routeList)
        {
            RouteList = routeList;
        }
        public float GetDistance()
        {
            float totalDistance = 0;
            foreach(Route r in RouteList)
            {
                totalDistance += r.GetDistance();
            }
            return totalDistance;
        }

        public override string ToString()
        {
           string s = "\nPlan puta: ";
           foreach(Route r in this.RouteList)
            {
                s += r.ToString();
            }
            s += "\n\nUkupna prijeđena udaljenost: " + GetDistance()/1000 + " km";
            return s;
        }

        public void DisplayOnBrowser()
        {
            foreach (Route r in RouteList)
            {
                r.DisplayOnBrowser();
            }
        }

        public void SaveImage()
        {
            foreach(Route r in RouteList)
            {
                r.SaveImage();
            }
        }
    }
}
