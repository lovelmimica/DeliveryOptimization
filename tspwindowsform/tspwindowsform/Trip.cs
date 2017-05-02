using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{
    class Trip
    {
        private static Trip instance = null;
        private char addressSeparator = ';';

        private Trip(){
            this.DestinationList = new List<Address>();
        }

        public static Trip GetInstance()
        {
            if (instance == null) instance = new Trip();
            return instance;
        }

        public Address Origin { get; set; }
        public List<Address> DestinationList { get; set; }
        public int VehicleCount { get; set; }
        public TripPlan Plan { get; set; }

        public void Initialize(Address startAddress, string addressFile, int vehicleCount)
        {
            this.Origin = startAddress;
            LoadAddresses(addressFile);
            SetAddressDistances();
            this.VehicleCount = vehicleCount;
        }
        public void Display()
        {
            Plan.DisplayOnBrowser();
        }


        private void LoadAddresses(string path)
        {
            string addressesRaw = TxtFileHelper.LoadText(path);
            string[] addressesString = addressesRaw.Split(this.addressSeparator);

            foreach (string address in addressesString)
            {
                if (address.Length > 0)
                {
                    //kreiraj objekt klase Address sa paremetrom naziva
                    Address a = new Address(address.Trim());
                    //dodaj novokreirani objekt u listu adresa
                    if(DestinationList.Contains(a) == false) this.DestinationList.Add(a);
                }
            }
        }
        private void SetAddressDistances()
        {
            List<Address> destinationsTempList = new List<Address>(DestinationList);
                
            //setaj udaljenost izmeju ishodista i svih adresa
            foreach(Address a in destinationsTempList)
            {
                AddDistance(Origin, a);
                AddDistance(a, Origin);
            }
            //setaj međusobne udaljenosti između svih adresa međusobno
            destinationsTempList = new List<Address>(DestinationList);
            foreach(Address firstAddress  in destinationsTempList)
            {
                foreach(Address secondAddress in destinationsTempList)
                {
                    AddDistance(firstAddress, secondAddress);
                }
            }
        }
        private void AddDistance(Address source, Address destination)
        {
            if(source.Equals(destination) == false)
            {
                int distance;
                try
                {
                    distance = GoogleDirectionApiClient.RequestDistance(source.Name, destination.Name);
                    float newDistance = distance / 1000;
                  
                    source.AddDistance(destination, distance);
                }
                catch (Exception e)
                {
                    //TODO: ukloni adresu koja je stvarala problem (npr onu koja ne postoji ili je krivo napisana)
                    throw e;
                }
            }else source.AddDistance(destination, 0);
        }
    }
}
