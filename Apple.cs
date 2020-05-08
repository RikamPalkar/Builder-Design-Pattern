namespace Bridge_Design_Pattern
{
    public abstract class Apple
    {
        IRequisite RequiredHardware { get; set; }
        IRequisite RequiredSoftware { get; set; }

        public Apple(IRequisite hardware, IRequisite software)
        {
            this.RequiredHardware = hardware;
            this.RequiredSoftware = software;
        }
        public abstract string SetProductName();
        public abstract double SetProductPrice();

        public void SetHardware() {
            System.Console.WriteLine("---------Hardware Details---------");
            System.Console.WriteLine(" Name: "+RequiredHardware.SetFirmwareOrSoftwareName());
            System.Console.WriteLine(" Version: "+RequiredHardware.SetFirmwareOrSoftwareVesrion());
            System.Console.WriteLine(" Price: "+RequiredHardware.SetPrice());
        }
        public void SetSoftware()
        {
            System.Console.WriteLine("---------Software Details---------");
            System.Console.WriteLine(" Name: " + RequiredSoftware.SetFirmwareOrSoftwareName());
            System.Console.WriteLine(" Version: "+RequiredSoftware.SetFirmwareOrSoftwareVesrion());
            System.Console.WriteLine(" Price: " + RequiredSoftware.SetPrice());
        }
    }
}
