using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Before
{
    internal abstract class Vehicle
    {
        public string Name { get; set; }
        public double Speed { get; set; }
        public Engine Engine { get; set; }
        public virtual void StartEngine()
        {
            Engine.Start();
        }

    }
    class Engine
    {
        public string Name { get; set; }
        public double Power { get; set; }

        public void Start()
        {
            Console.WriteLine("Engine started");
        }
    }
}
