using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregationAndContainment_MatthewVargas
{
    internal class Instructor
    {
        public Instructor(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public string _firstName { get; set; }
        public string _lastName { get; set; }

        public override string ToString()
        {
            return ($"{_firstName} {_lastName}");
        }

    }
}
