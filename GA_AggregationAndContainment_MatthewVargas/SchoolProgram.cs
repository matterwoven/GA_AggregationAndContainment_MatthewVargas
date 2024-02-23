using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregationAndContainment_MatthewVargas
{
    internal class SchoolProgram
    {
        List<Student> _classRoster;

        public SchoolProgram(string className, string classNumber, string roomNumber, Instructor instructor) 
        {
            _className = className;
            _classNumber = classNumber;
            _roomNumber = roomNumber;
            Instructor _instructor = instructor;
            _classRoster = new List<Student>();
        }

        public string _className { get; set; }
        public string _classNumber { get; set; }
        public string _roomNumber { get; set; }
        public Instructor _instructor { get; set; }

        internal void AddStudent(Student student) 
        {
            _classRoster.Add(student);
        }
        internal void AddStudent(string firstName, string lastName, int csiGrade, int genEdGrade) 
        {
            string _firstName = firstName;
            string _lastName = lastName;
            int _csiGrade = csiGrade;
            int _genEdGrade = genEdGrade;

            Student student = new Student($"{_firstName}", $"{_lastName}", _csiGrade, _genEdGrade);
            _classRoster.Add(student);
        }

        public override string ToString()
        {
            return $"{_className} - Class Number: {_classNumber} - Room #{_roomNumber} - Instructor Name: {_instructor}, Student Count: {_classRoster.Count}";
        }
        public void StudentsInfo()
        {
            foreach (var student in _classRoster)
            {
                Console.WriteLine(student.ToString());
            }
        }

    }
}
