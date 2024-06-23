using MarketingSurplus.Models;

namespace MarketingSurplus.Dto
{
    public class SaveCompanyProduct
    {
        public Product Product { get; set; }
        public int CompanyId { get; set; }
        public int Amount { get; set; }
    }
}
