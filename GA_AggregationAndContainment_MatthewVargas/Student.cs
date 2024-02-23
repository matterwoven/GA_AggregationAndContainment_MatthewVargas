using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregationAndContainment_MatthewVargas
{

    internal class Student
    {
        public Student(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = csiGrade;
            _genEdGrade = genEdGrade;
        }
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public int _csiGrade { get; set; }
        public int _genEdGrade { get; set; }

        public override string ToString()
        {
            return ($"{_firstName} {_lastName} - CSI Grade: {_csiGrade} - GenEd Grade: {_genEdGrade}");
        }

    }
}
