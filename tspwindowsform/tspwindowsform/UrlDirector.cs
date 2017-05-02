using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{
    class UrlDirector
    {
        public static string CreateUrl(List<Address> addresses, AbstractMapUrlBuilder urlBuilder)
        {     
            urlBuilder.SetAddressList(addresses);
            urlBuilder.AddBaseUrl();
            urlBuilder.AddStartAddress();
            urlBuilder.AddDestinationAddresses();

            return urlBuilder.GetUrl();
        }
    }
}
