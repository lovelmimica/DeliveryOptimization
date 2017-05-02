using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using traveling_salesman_problem;

namespace traveling_salesman_problem
{
    class GoogleMapUrlBuilder : AbstractMapUrlBuilder
    {

        public override void AddBaseUrl()
        {
            AppendString("http://maps.google.hr/maps?");
        }
        public override void AddStartAddress()
        {
            string startAddress = this.addressNames.ElementAt(0);
            AppendString("saddr=" + startAddress + "&&");
        }
        public override void AddDestinationAddresses()
        {
            List<string> destinations = addressNames.GetRange(1, (addressNames.Count - 1));
            StringBuilder sb = new StringBuilder();
            sb.Append("daddr=" + destinations.ElementAt(0));
            for (int i = 1; i < destinations.Count; i++)
            {
                sb.Append("+to:" + destinations.ElementAt(i));
            }
            AppendString(sb.ToString());
        }
        
    }
}
