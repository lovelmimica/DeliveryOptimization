using System.Collections.Generic;

namespace traveling_salesman_problem
{
    abstract class AbstractMapUrlBuilder
    {
        protected List<string> addressNames;
        private string url = "";

        public abstract void AddBaseUrl();
        public abstract void AddDestinationAddresses();
        public abstract void AddStartAddress();


        public string GetUrl()
        {
            return this.url;
        }
        public void SetAddressList(List<Address> addressList)
        {
            addressNames = new List<string>();
            foreach (Address a in addressList)
            {
                addressNames.Add(a.Name.Replace(" ", "+"));
            }

        }
        protected void AppendString(string s)
        {
            this.url += s;
        }
    }
}