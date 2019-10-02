using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCSharp
{
    public class Person
    {
        public DateTime BirthDate { get; private set; }

        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        public int Age
        {
            get
            {
                var timespan = DateTime.Today - BirthDate;
                return timespan.Days / 365;
            }
        }
    }
}
