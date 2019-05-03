namespace Purchase
{
    /// <summary>
    /// 审批人,Handler
    /// </summary>
    public abstract class Approver
    {
        public Approver NextApprover { get; set; }
        public string Name { get; set; }

        protected Approver(string name)
        {
            Name = name;
        }
        public abstract void ProcessRequest(PurchaseRequest request);
    }
}