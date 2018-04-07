using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Person
    {
        private string _navn;
        public string Navn
        {
            get { return _navn; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _navn = value;
                }
            }
        }

        public Person(string navn)
        {
            Navn = navn;
        }
    }
}
