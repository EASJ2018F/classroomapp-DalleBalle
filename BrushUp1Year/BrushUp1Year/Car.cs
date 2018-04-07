using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUp1Year
{
    public class Car
    {
        // Fields
        private int _doors;
        private string _model;
        private string _registrationNo;
        Color _color;

        // Properties
        public int Doors
        {
            get { return _doors; }
            set
            {
                if (value >= 2 && value <= 5)
                {
                    _doors = value;
                }
                else
                {
                    throw new Exception("Bilen skal have mellem 2 og 5 døre.");
                }
            }
        }

        public string Model
        {
            get { return _model; }
            set
            {
                if (value != null)
                {
                    _model = value;
                }
                else
                {
                    throw new Exception("Der er intet modelnavn.");
                }
            }
        }

        public string RegistrationNo
        {
            get { return _registrationNo; }
            set
            {}
        }

        // Constructor
        public Car(int doors, string model, string registrationNo, Color color)
        {
            this.Doors = doors;
            this.Model = model;
            this.RegistrationNo = registrationNo;
            this._color = color;
        }
    }
}
