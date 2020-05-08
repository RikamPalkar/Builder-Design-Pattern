namespace Bridge_Design_Pattern
{
    public class MacBook : Apple
    {
     
        public MacBook(IRequisite hardware, IRequisite software) : base(hardware, software)
        {

        }

        public override string SetProductName()
        {
            return  "Apple MacBook Pro";
        }

        public override double SetProductPrice()
        {
            return  170000;
        }
    }
}
