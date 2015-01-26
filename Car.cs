using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExamples
{
    class Car
    {
        public readonly String Brand;
        public readonly String Model;

        protected IEngine _engine;
        private int _gear;

        public int Gear
        {
            get { return _gear; }
            private set { _gear = value; }
        }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public void drive()
        {
            _engine.Drive();
        }

        public void ShiftGear(int gear)
        {
            Gear = gear;
        }

        public override string ToString()
        {
            return Brand + " " + Model;
        }
    }
}
