using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_RS_VelibLabServices
{
    [ServiceContract]
    public interface IVelibLabServices
    {
        [OperationContract]
        List<City> GetCities();

        [OperationContract]
        List<Station> GetStations(string city);

        [OperationContract]
        Station GetStation(string city, string station_name);
    }
    
    [DataContract]
    public class City
    {
        string name = "City_Name";

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    [DataContract]
    public class Station
    {
        string name = "Station_Name";
        int available_bikes = -1;

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public int Available_bikes
        {
            get { return available_bikes; }
            set { available_bikes = value; }
        }
    }
}
