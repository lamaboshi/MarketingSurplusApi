using MarketingSurplus.Dto;
using MarketingSurplus.Models;

namespace MarketingSurplus.Infrastructure
{
    public interface IDonation
    {
        List<Donation> GetAllDonationForCompany(int companyId);
        List<ProductDonation> GetAllOrder(int charityId);
        List<Company> GetAllCompanyForThis(int charityId);
        public int SaveProductDonation(ProductDonation productDonation);
        public int SaveDonation(Donation donation);
        public void UpdateStutasDonation(int idDonation, UpdateDontation updateDontation);
        Donation GetDonation(int Id);

    }
}
