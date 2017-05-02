using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{
    class Algorithm
    {
        public void OrganizeTrip(Trip trip)
        {
            //0. sva vozila su u ishodistu
            List<Route> routeList = new List<Route>();
            for(int i = 0; i<trip.VehicleCount; i++)
            {
                routeList.Add(new Route(trip.Origin));
            }
            List<Address> residualDestinations = trip.DestinationList;


           //1. provjeriti da li ima jos NEOBAĐENIH destinacija (ako nema onda => KRAJ)
           while(residualDestinations.Count > 0)
            {
                //2. odrediti  najblize lokacije svakom vozilu
                List<Address> closestDestinations = new List<Address>();
                //za svako vozilo pronaci najblizu mu destinaciju (sa pripadajucom udaljenosti)

                int minDistance = int.MaxValue;
                int updatedRouteIndex = 0;
                Address closestDestination = null;
                foreach (Route r in routeList)
                {
                    Address tempClosestDestination = FindClosestDestination(r.LastDestination, residualDestinations);
                    closestDestinations.Add(tempClosestDestination);
                    int tempDistance = r.LastDestination.GetDistance(tempClosestDestination);

                    if (tempDistance < minDistance)
                    {
                        minDistance = tempDistance;
                        updatedRouteIndex = routeList.IndexOf(r);
                        closestDestination = tempClosestDestination;
                    }
                }

                //3. poslati vozilo sa najmanjom udaljenosti na doticnu lokaciju
                Route updatedRoute = routeList.ElementAt(updatedRouteIndex);
                updatedRoute.AddDestination(closestDestination);
                residualDestinations.Remove(closestDestination);
                //4. ponoviti korak 1
            }

            //TODO: zaustavi algoritam i vrati vozila na pocetnu lokaciju
            foreach(Route r in routeList)
            {
                r.AddDestination(trip.Origin);
            }


            TripPlan plan = new TripPlan(routeList);
            trip.Plan = plan;
        }

        private Address FindClosestDestination(Address source,  List<Address> destinationList)
        {
            if (destinationList == null || destinationList.Count == 0) throw new Exception("Empty destination list");

            Address closestDestination = destinationList.ElementAt(0);
            int closestDistance = source.GetDistance(closestDestination);
            foreach(Address destination in destinationList)
            {
                if(closestDistance > source.GetDistance(destination))
                {
                    closestDistance = source.GetDistance(destination);
                    closestDestination = destination;
                }
            }
            return closestDestination;
        }

        
    }
}
