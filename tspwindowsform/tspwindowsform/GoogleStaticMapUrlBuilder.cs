using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{
    class GoogleStaticMapUrlBuilder : AbstractMapUrlBuilder
    {
        public override void AddBaseUrl()
        {
            AppendString("https://maps.googleapis.com/maps/api/staticmap?size=640x640&maptype=roadmap&key=AIzaSyDcZtc0R2rvphieO6N3sDmxOPIeS9esyCI&path=");
        }

        public override void AddDestinationAddresses()
        {
            List<string> destinations = addressNames.GetRange(1, (addressNames.Count - 1));
            StringBuilder sb = new StringBuilder();
            /*sb.Append("daddr=" + destinations.ElementAt(0));
            for (int i = 1; i < destinations.Count; i++)
            {
                sb.Append("+to:" + destinations.ElementAt(i));
            }*/
            foreach(string address in destinations)
            {
                sb.Append("|" + address);
            }
            
            AppendString(sb.ToString() + "&markers=" + sb.ToString());               
        }

        public override void AddStartAddress()
        {
            string startAddress = this.addressNames.ElementAt(0);
            AppendString(startAddress);
        }
    }
}
