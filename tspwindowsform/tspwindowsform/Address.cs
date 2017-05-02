using System;
using System.Collections;

namespace traveling_salesman_problem
{
    class Address
    {
        private Hashtable distancesTable;

        public Address(string name)
        {
            Name = name;
            distancesTable = new Hashtable();
            distancesTable.Add(this, 0);
        }

        public String Name { get; }
        
        public int GetDistance(Address address)
        {
            if (distancesTable.Contains(address)) return (int)distancesTable[address];
            else throw new Exception("No address name in distancesTable");
        }
        public void AddDistance(Address address,  int distance)
        {
            if(distancesTable.ContainsKey(address))
            {
                distancesTable.Remove(address);
            }
            distancesTable.Add(address, distance);
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType().Equals(this.GetType()))
            {
                Address secondAddress = (Address)obj;
                if (this.Name.Equals(secondAddress.Name)) return true;
            }
            return false;
        }

    }
}
