namespace Bridge_Design_Pattern
{
    public class Hardware : IRequisite
    {
        public string SetFirmwareOrSoftwareName()
        {
            return "MotherBoard FirmWare";
        }

        public string SetFirmwareOrSoftwareVesrion()
        {
            return  "5.0";
        }

        public double SetPrice()
        {
            return  20000;
        }
    }
}
