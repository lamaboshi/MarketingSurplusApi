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
                    pro.IsExpiration = true;
                    _db.SaveChanges();
                }

            }
            data = _db.CompanyProducts.Where(q => q.CompanyId == companyId).Include(q => q.Product).ToList();
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

        public List<OrderDto> GetOrderDetails(int idOrder)
        {
            var details =new  List<OrderDto>();
            var order = _db.Orders.Where(q => q.Id == idOrder).FirstOrDefault();
            var orderPro = _db.OrderProducts.Where(q => q.OrderId == idOrder).ToList();
            if(orderPro != null)
            {
                foreach (var item in orderPro)
                {
                    var pro = _db.CompanyProducts.Where(e => e.Id == item.CompanyProductId).Include(t=>t.Product).Include(r=>r.Company).FirstOrDefault();
                    var bills = _db.Bills.Where(q => q.OrderProductId == item.Id).ToList();
                    details.Add(new OrderDto { OrderProduct=item,Bills=bills, Order= order ,Company= pro.Company,Product=pro.Product});
                }
            }
            return details;
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
   
        public int SaveOrder(SaveOrderRequestDto request)
        {
            request.Order.UserId = request.UserId;
             var result=_db.Orders.Add(request.Order);
            _db.SaveChanges();
            foreach (var item in request.Ids)
            {
                 var stutas=   _db.OrderProducts.Add(new OrderProduct { CompanyProductId = item, OrderId = result.Entity.Id });
                _db.SaveChanges();
                _db.Bills.Add(new Bill { OrderProductId = stutas.Entity.Id, OrderStatusId = 1 });
                _db.SaveChanges();
            }
            return result.Entity.Id;
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
