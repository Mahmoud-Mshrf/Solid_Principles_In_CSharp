using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.After
{
    // in this example, we have a Vehicle class that has two subclasses: VehicleWithEngine and VehicleWithoutEngine.
    // VehicleWithEngine has an Engine property and a StartEngine method, while VehicleWithoutEngine has a StartMoving method.
    // Both subclasses inherit from the Vehicle class, which has a Name and Speed property.
    // in this example, the inheritance hierarchy is correct, and the subclasses are substitutable for the base class.
    // The VehicleWithEngine and VehicleWithoutEngine classes can be used interchangeably with the Vehicle class without affecting the behavior of the system.

    internal abstract class Vehicle
    {
        public string Name { get; set; }
        public double Speed { get; set; }
    }
    class Engine
    {
        public string Name { get; set; }
        public double Power { get; set; }
    }
}
