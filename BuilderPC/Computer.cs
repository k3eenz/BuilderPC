using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPC
{
    public class Computer
    {
        public CPU Cpu { get; }
        public Motherboard Motherboard { get; }
        public RAM Ram { get; }
        public Storage Storage { get; }
        public GPU Gpu { get; }

        public Computer(CPU cpu, Motherboard motherboard, RAM ram, Storage storage, GPU gpu)
        {
            Cpu = cpu;
            Motherboard = motherboard;
            Ram = ram;
            Storage = storage;
            Gpu = gpu;
        }

        public void DisplayConfiguration()
        {
            Console.WriteLine($"CPU: {Cpu.Model}");
            Console.WriteLine($"Motherboard: {Motherboard.Model}");
            Console.WriteLine($"RAM: {Ram.Capacity}");
            Console.WriteLine($"Storage: {Storage.Type} {Storage.Capacity}");
            Console.WriteLine($"GPU: {Gpu.Model}");
        }
    }

}
