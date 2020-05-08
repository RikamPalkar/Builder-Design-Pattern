namespace Bridge_Design_Pattern
{
    public class SoftWare : IRequisite
    {
     
        public double SetPrice()
        {
            return  15000;
        }

        public string SetFirmwareOrSoftwareVesrion()
        {
            return  "IOS production version 13.2";
        }

        public string SetFirmwareOrSoftwareName()
        {
            return  "IOS 13.2";
        }
    }
}
