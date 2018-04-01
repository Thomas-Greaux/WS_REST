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
    }

    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    // Vous pouvez ajouter des fichiers XSD au projet. Une fois le projet généré, vous pouvez utiliser directement les types de données qui y sont définis, avec l'espace de noms "WS_RS_VelibLabServices.ContractType".
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
}
