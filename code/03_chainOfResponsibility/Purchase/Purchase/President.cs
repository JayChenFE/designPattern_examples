using System;

namespace Purchase
{
    public class President : Approver
    {
        public President(string name) : base(name)
        {

        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 100000.0)
            {
                Console.WriteLine("{0}-{1} approved the request of purchasing {2}", this, Name, request.ProductName);
            }
            else
            {
                Console.WriteLine("Request需要组织一个会议讨论");
            }
        }
    }
}