using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static Dictionary<string, Student> _students = new Dictionary<string, Student>();
        
        public void AddStudent(string navn, string klasseNavn, string rum)
        {
            _students.Add(navn, new Student(navn, klasseNavn, rum));
        }

        public string FindStudents(string navn)
        {
            return _students[navn].ToString();
        }

        public List<string> GetAllStudent()
        {
            List<Student> studentList = new List<Student>(_students.Values);
            List<string> stringList = new List<string>();

            foreach (var student in studentList)        
            {
                stringList.Add(student.ToString());
            }

            return stringList;
        }

        public void RemoveStudent(string navn )
        {
            _students.Remove(navn);
        }

        public void EditStudent(string nuværendeNavn, string nytNavn, string nytKlasseNavn, string nytRum)
        {
            _students[nuværendeNavn].Navn = nytNavn;
            _students[nuværendeNavn].KlasseNavn = nytKlasseNavn;
            _students[nuværendeNavn].Rum = nytRum;
        }
    }
}
