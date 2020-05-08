using System;

namespace Bridge_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple Iphone = new IPhone(new Hardware(), new SoftWare());
            Console.WriteLine("---- IPhone Details ----");
            Console.WriteLine($" Product: {Iphone.SetProductName()} \n Price: {Iphone.SetProductPrice()}");
            Iphone.SetSoftware();
            Iphone.SetHardware();
            Apple MacBook = new MacBook(new Hardware(), new SoftWare());
            Console.WriteLine(Environment.NewLine + Environment.NewLine +"---- MacBook Pro Details ----");
            Console.WriteLine($" Product: {MacBook.SetProductName()} \n Price: {MacBook.SetProductPrice()}");
            MacBook.SetSoftware();
            MacBook.SetHardware();
        }
    }
}
