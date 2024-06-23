using MarketingSurplus.Models;

namespace MarketingSurplus.Dto
{
    public class CompnyProductDto
    {
 
        public CompanyProduct CompanyProduct { get; set; }
        public Subscription? subscription { get; set; }
        public int? RateNumber { get; set; }
        public CompanyType CompanyType { get; set; }

    }
}
