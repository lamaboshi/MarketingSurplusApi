using MarketingSurplus.Models;

namespace MarketingSurplus.Infrastructure
{
    public interface IDonation
    {
        List<Donation> GetAllDonationForCompany(int companyId);
        List<ProductDonation> GetAllOrder(int charityId);
        List<Company> GetAllCompanyForThis(int charityId);
        public void SaveProductDonation(ProductDonation productDonation);
        int SaveDonation(Donation donation);
        Donation GetDonation(int Id);

    }
}
