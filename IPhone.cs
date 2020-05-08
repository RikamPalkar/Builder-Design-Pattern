namespace Bridge_Design_Pattern
{
    public class IPhone : Apple
    {
      
        public IPhone(IRequisite hardware, IRequisite software): base(hardware, software)
        {

        }

       
        public override string SetProductName()
        {
           return "IPhone X";
        }

        public override double SetProductPrice()
        {
            return  110000;
        }
    }
}
