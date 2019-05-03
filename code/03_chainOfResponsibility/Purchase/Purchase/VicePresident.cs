using System;

namespace Purchase
{
    /// <summary>
    ///  ConcreteHandler,副总
    /// </summary>
    public class VicePresident : Approver
    {
        public VicePresident(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 25000.0)
            {
                Console.WriteLine("{0}-{1} approved the request of purchasing {2}", this, Name, request.ProductName);
            }
            else
            {
                NextApprover?.ProcessRequest(request);
            }
        }
    }
}