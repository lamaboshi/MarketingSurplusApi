using MarketingSurplus.Dto;
using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;
using Microsoft.EntityFrameworkCore;

namespace MarketingSurplus.Data
{
    public class MainRepo : IMain
    {
        private readonly MarketingSurplusDbContext _db;
        public MainRepo(MarketingSurplusDbContext db)
        {
            _db = db;
        }

        public void AddCompanyProduct(SaveCompanyProduct saveCompany)
        {
            var result = _db.Products.Add(saveCompany.Product);
            _db.SaveChanges();

            _db.CompanyProducts.Add(new CompanyProduct { ProductId = result.Entity.Id, CompanyId = saveCompany.CompanyId, Amount = saveCompany.Amount });
            _db.SaveChanges();
        }

        public List<CompanyProduct> GetAllCompanyProduct(int companyId)
        {
           var data=_db.CompanyProducts.Where(q=>q.CompanyId == companyId).Include(q=>q.Product).ToList();
            foreach (var item in data)
            {
                if (item.Product.Expiration < DateTime.Now)
                {
                    var pro = _db.Products.Where(q => q.Id == item.Id).SingleOrDefault();
                    if (pro != null)
                    {
                        pro.IsExpiration = true;
                        _db.SaveChanges();
                    }

                }

            }
            data = _db.CompanyProducts.Where(q => q.CompanyId == companyId).Include(q => q.Product).ToList();
            return data;
        }

        public List<User> GetAllCompanyUsers(int companyId)
        {
            var data = _db.Subscriptions.Where(r => r.CompanyId == companyId).Include(q=>q.User).Select(w=>w.User).ToList();
            return data;
        }

        public List<CompnyProductDto> GetAllPosts(int UserId)
        {
            var products = new List<CompnyProductDto>();
            var allCompanyProduct = _db.CompanyProducts.ToList();
            foreach (var item in allCompanyProduct)
            {
                var CompProduct = new CompnyProductDto();
                var company = _db.Companies.Where(e => e.Id == item.CompanyId).FirstOrDefault();
                if(company != null)
                {
                    item.Company = company;
                    var type=_db.CompanyTypes.Where(q=>q.Id==company.CompanyTypeId).FirstOrDefault();
                    CompProduct.CompanyType = type!;
                    if (UserId != 0)
                    {
                        var subscri = _db.Subscriptions.Where(q => q.UserId == UserId && q.CompanyId == company.Id).FirstOrDefault();
                        CompProduct.subscription = subscri;
                        if (subscri != null)
                        {
                            var rate = _db.Evalution.Where(q => q.SubscriptionId == subscri.Id).Include(e => e.Rate).Select(q => q.Rate.RateNumber).FirstOrDefault();
                            CompProduct.RateNumber = rate == null ? 0 : rate;
                        }
                    }

                }
                var product=_db.Products.Where(q=>q.Id == item.ProductId).FirstOrDefault();
                if (product != null)
                {
                    item.Product = product;
                       

                }
                CompProduct.CompanyProduct = item;
                products.Add(CompProduct);
            }
            return products;
        }

        public List<OrderProduct> GetOrderDetails(int userId)
        {

            var allOrder = new List<OrderProduct>();
            var data = _db.Orders.Where(q => q.UserId == userId).ToList();
            foreach (var order in data)
            {

                var allProduct = _db.OrderProducts.Where(e => e.OrderId == order.Id).ToList();
                if (allProduct.Count!=0)
                {
                    foreach (var product in allProduct)
                    {
                        var pro = _db.CompanyProducts.Where(e => e.Id == product.CompanyProductId).Include(t => t.Product).Include(r => r.Company).FirstOrDefault();
                        var bills = _db.Bills.Where(q => q.OrderProductId == product.Id).ToList();
                        allOrder.Add(product);
                    }
                }
         
            }

            return allOrder;

        }

        public List<CompnyProductDto> GetSubscriptionPosts(int id)
        {
            var products = new List<CompnyProductDto>();
            var allCompanyProduct = _db.CompanyProducts.ToList();
            foreach (var item in allCompanyProduct)
            {
                var CompProduct = new CompnyProductDto();
                var company = _db.Companies.Where(e => e.Id == item.CompanyId).FirstOrDefault();
          
                if (company != null)
                {
                    var subscri = _db.Subscriptions.Where(q => q.UserId == id && q.CompanyId == company.Id).FirstOrDefault();
                     if(subscri != null)
                    {
                        item.Company = company;
                        var type = _db.CompanyTypes.Where(q => q.Id == company.CompanyTypeId).FirstOrDefault();
                        CompProduct.CompanyType = type!;
                        var product = _db.Products.Where(q => q.Id == item.ProductId).FirstOrDefault();
                        if (product != null)
                        {
                            item.Product = product;
                        }
                        var rate=_db.Evalution.Where(q=>q.SubscriptionId== subscri.Id).Include(e=>e.Rate).Select(q => q.Rate.RateNumber).FirstOrDefault();
                        CompProduct.RateNumber = rate == null ? 0 : rate;
                        CompProduct.CompanyProduct = item;
                        products.Add(CompProduct);
                    }

                }

            }
            return products;
        }
   


        public int SaveOrder(Order order)
        {
            var result = _db.Orders.Add(order);
            _db.SaveChanges();
            return result.Entity.Id;
        }

        public void SaveOrderProduct(OrderProduct orderProduct)
        {
 
            var stutas = _db.OrderProducts.Add(orderProduct);
            _db.SaveChanges();
            _db.Bills.Add(new Bill { OrderProductId = stutas.Entity.Id, OrderStatusId = 1 });
            _db.SaveChanges();
        }

        public void UpdateStutasOrder(int  idOrder, int Stutas)
        {
            var order = _db.Orders.Where(q => q.Id == idOrder).FirstOrDefault();
            var allProduct = _db.OrderProducts.Where(r => r.OrderId == idOrder).ToList();
            foreach (var item in allProduct)
            {
                var lastStutas = _db.Bills.Where(t=>t.OrderProductId==item.Id).Include(e=>e.OrderStatus).Select(r=>r.OrderStatus).ToList();
                if(!lastStutas.Any(r=>r.status== Stutas))
                {
                    var idS = _db.OrderStatuses.Where(t => t.status == Stutas).First().Id;
                    _db.Bills.Add(new Bill { OrderProductId = item.Id, OrderStatusId = idS });
                }
                    
            }

        }

    }
}
