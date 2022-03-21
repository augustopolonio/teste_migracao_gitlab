using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TutorialAPI.EDM;

namespace TutorialAPI.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUsuarios" in both code and config file together.
    [ServiceContract]
    public interface IUsuarios
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        void CreateUser();

        [OperationContract]
        void ReadUser();

        [OperationContract]
        void UpdateUser(int id);

        [OperationContract]
        void DeleteUser(int id);

        [OperationContract]
        void AnotherTest();

        [OperationContract]
        USUARIOS[] GetAllUsers();
    }
}
