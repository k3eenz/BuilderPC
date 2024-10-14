using BuilderPC;

ComputerBuilder builder = new ComputerBuilder();
Computer myComputer = builder
  .SetCPU(new CPU("AMD Ryzen 9 7950X"))
  .SetMotherboard(new Motherboard("MSI MEG X670E Ace"))
  .SetRAM(new RAM("64GB DDR5"))
  .SetStorage(new Storage("NVMe SSD", "2TB"))
  .SetGPU(new GPU("AMD Radeon RX 7900 XT"))
  .Build();
myComputer.DisplayConfiguration();
