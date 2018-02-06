using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUp1Year
{
    class Owner
    {
        // Fields
        private string _address;
        private string _name;
        private string _phone;

        // Properties
        public string Address
        {
            get { return _address; }
            set
            {
                
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        // Constructor
        public Owner(string address, string name, string phone)
        {
            this.Address = address;
            this.Name = name;
            this.Phone = phone;
        }
    }
}
