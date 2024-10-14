using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPC
{
    public class CPU
    {
        public string Model { get; }
        public CPU(string model) => Model = model;
    }

    public class Motherboard
    {
        public string Model { get; }
        public Motherboard(string model) => Model = model;
    }

    public class RAM
    {
        public string Capacity { get; }
        public RAM(string capacity) => Capacity = capacity;
    }

    public class Storage
    {
        public string Type { get; }
        public string Capacity { get; }
        public Storage(string type, string capacity)
        {
            Type = type;
            Capacity = capacity;
        }
    }

    public class GPU
    {
        public string Model { get; }
        public GPU(string model) => Model = model;
    }

}
