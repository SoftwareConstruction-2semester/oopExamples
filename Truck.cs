using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExamples
{
    class Truck : Car
    {
        public readonly int LoadCapacity;

        public Truck(string brand, string model, int loadCapacity) : base(brand, model)
        {
            LoadCapacity = loadCapacity;
            // do the rest in base class constructor
        }

        public Truck(String brand, string model, int loadCapacity, IEngine engine) : this(brand, model, loadCapacity)
        {
            this._engine = engine;
            // do the rest in the other constructor
        }

        public override string ToString()
        {
            if (_engine != null)
                return base.ToString() + LoadCapacity + _engine.ToString();
            else
                return base.ToString() + LoadCapacity;
        }
    }
}
