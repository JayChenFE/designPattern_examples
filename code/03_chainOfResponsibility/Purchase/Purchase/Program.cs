using System;

namespace Purchase
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchaseRequest requestTelphone = new PurchaseRequest(4000.0, "Telephone");
            PurchaseRequest requestSoftware = new PurchaseRequest(10000.0, "Visual Studio");
            PurchaseRequest requestComputers = new PurchaseRequest(40000.0, "Computers");

            Approver manager = new Manager("LearningHard");
            Approver vp = new VicePresident("Tony");
            Approver pre = new President("BossTom");

            // 设置责任链
            manager.NextApprover = vp;
            vp.NextApprover = pre;

            // 处理请求
            manager.ProcessRequest(requestTelphone);
            manager.ProcessRequest(requestSoftware);
            manager.ProcessRequest(requestComputers);
            Console.ReadLine();
        }
    }
}
