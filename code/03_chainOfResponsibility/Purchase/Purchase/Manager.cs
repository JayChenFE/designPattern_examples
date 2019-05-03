using System;

namespace Purchase
{
    /// <summary>
    /// ConcreteHandler
    /// </summary>
    public class Manager : Approver
    {
        public Manager(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 10000.0)
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