namespace MarketingSurplus.Models
{
    public class UserCompanyRate
    {
        public int Id { get; set; }
        public int UserCompanyId { get; set; }
        public UserCompany UserCompany { get; set; }
        public int RateId { get; set; }
        public Rate Rate { get; set; }
    }
}
