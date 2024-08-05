using MarketingSurplus.Dto;
using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;
using Microsoft.EntityFrameworkCore;

namespace MarketingSurplus.Data
{
    public class DonationRepo : IDonation
    {
        private readonly MarketingSurplusDbContext _db;
        public DonationRepo(MarketingSurplusDbContext db)
        {
            _db = db;
        }

        public List<Company> GetAllCompanyForThis(int charityId)
        {
            var companies =new List<Company>();
            var data = _db.ProductDonations.Include(t=>t.Donation).Where(q => q.Donation.CharityId == charityId).Select(r=>r.CompanyProduct.Company).ToList();
            return data;
        }

        public List<Donation> GetAllDonationForCompany(int companyId)
        {
            var dos =new List<Donation>();
            var data = _db.ProductDonations.Include(p => p.CompanyProduct).Where(r => r.CompanyProduct.CompanyId == companyId).Select(k=>k.Donation).ToList();
            foreach (var item in data)
            {
                var result = _db.Donations.Where(t => t.Id == item.Id).Include(y => y.Charity).Include(r => r.OrderType).FirstOrDefault();
                dos.Add(result);
            }

            return dos;
        }

        public List<ProductDonation> GetAllOrder(int charityId)
        {
            var allOrder = new List<ProductDonation>();
            var data = _db.Donations.Where(q => q.CharityId == charityId).ToList();
            foreach (var order in data)
            {

                var allProduct = _db.ProductDonations.Where(e => e.DonationId == order.Id).ToList();
                if (allProduct.Count != 0)
                {
                    foreach (var product in allProduct)
                    {
                        var pro = _db.CompanyProducts.Where(e => e.Id == product.CompanyProductId).Include(t => t.Product).Include(r => r.Company).FirstOrDefault();

                        allOrder.Add(product);
                    }
                }

            }

            return allOrder;
        }

        public Donation GetDonation(int Id)
        {
            var result = _db.Donations.First(p => p.Id == Id);
            if (result != null) return result;
            else return null;
        }

        public int SaveDonation(Donation donation)
        {
            var result = _db.Donations.Add(donation);
            _db.SaveChanges();
            return result.Entity.Id;
        }

        public int SaveProductDonation(ProductDonation productDonation)
        {
          var result=  _db.ProductDonations.Add(productDonation);
            _db.SaveChanges();

            var updateAmount = _db.CompanyProducts.Where(t => t.Id == productDonation.CompanyProductId).Single();
            var amount = updateAmount.Amount - productDonation.Amount;
            if (amount > 0)
            {
                updateAmount.Amount = amount;
                _db.SaveChanges();
            }
            else if (amount == 0)
            {
                _db.CompanyProducts.Remove(updateAmount);
                _db.SaveChanges();
            }
            return result.Entity.Id;
       
        }

        public void UpdateStutasDonation(int idDonation, UpdateDontation updateDontation)
        {
            var order = _db.Donations.Where(q => q.Id == idDonation).FirstOrDefault();
            var allProduct = _db.ProductDonations.Where(r => r.DonationId == idDonation).ToList();
            foreach (var item in allProduct)
            {
                item.IsAccept = updateDontation.Status;
                item.IsCompany = updateDontation.isCompany;
                item.IsCencal = updateDontation.isCencal;
                item.CommintCencal = updateDontation.commint;
                _db.SaveChanges();

            }

        }
    }
}
