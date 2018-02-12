using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void AddStudent(string navn, string klasseNavn, string rum);

        [OperationContract]
        string FindStudents(string navn);

        [OperationContract]
        List<string> GetAllStudent();

        [OperationContract]
        void RemoveStudent(string navn);

        [OperationContract]
        void EditStudent(string nuværendeNavn, string nytNavn, string nytKlasseNavn, string nytRum);
    }
}
