using System;

namespace ChainRealWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tamy = new President();

            larry.SetSucessor(sam);
            sam.SetSucessor(tamy);

            Purchase p = new Purchase(2034, 350.00, "Supplies");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);

            Console.ReadKey();
        }
    }
}
