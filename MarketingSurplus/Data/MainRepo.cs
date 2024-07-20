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

        public void DeleteProduct(int id)
        {
            var result = _db.Products.FirstOrDefault(p => p.Id == id);
            if (result != null)
            {

                _db.Products.Remove(result);
                _db.SaveChanges();
            }
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
        public int GetAnyRate(int companyId)
        {
            int rate = 0;
            Random rnd = new Random();
            rate = rnd.Next(1, 5);

            return rate;
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
                    CompProduct.RateNumber = GetAnyRate(company.CompanyTypeId);
                    if (UserId != 0)
                    {
                        var subscri = _db.Subscriptions.Where(q => q.UserId == UserId && q.CompanyId == company.Id).FirstOrDefault();
                        CompProduct.subscription = subscri;
                        if (subscri != null)
                        {
                            var rate = _db.Evalution.Where(t => t.SubscriptionId == subscri.Id).Include(t => t.Rate).FirstOrDefault();
                            if (rate != null)
                            {
                                CompProduct.Rate = rate.Rate;

                            }
                    

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

        public List<OrderProduct> GetOrderDetailsForCompany(int companyId)
        {
            var allOrder = new List<OrderProduct>();
            var data = _db.CompanyProducts.Where(q => q.CompanyId==companyId).ToList();
            foreach (var item in data)
            {
                var orderProduct = _db.OrderProducts.Where(p => p.CompanyProductId == item.Id).Include(t=>t.Order).Include(w=>w.Bills).ToList();
                foreach (var element in orderProduct)
                {
                    allOrder.Add(element!);
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
                    CompProduct.RateNumber = GetAnyRate(company.CompanyTypeId);
                    if (subscri != null)
                    {
                        item.Company = company;
                        var type = _db.CompanyTypes.Where(q => q.Id == company.CompanyTypeId).FirstOrDefault();
                        CompProduct.CompanyType = type!;
                        var product = _db.Products.Where(q => q.Id == item.ProductId).FirstOrDefault();
                        if (product != null)
                        {
                            item.Product = product;
                        }
                        var rate = _db.Evalution.Where(t => t.SubscriptionId == subscri.Id).Include(t => t.Rate).FirstOrDefault();
                        if (rate != null)
                        {
                            CompProduct.Rate = rate.Rate;

                        }
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
            var updateAmount = _db.CompanyProducts.Where(t => t.Id == orderProduct.CompanyProductId).Single();
            var amount = updateAmount.Amount - orderProduct.Amount;
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
        }

        public void UpdateProduct(Product product)
        {
            if (product.Id != 0)
            {
                var companyEntity = _db.Products.First(t => t.Id == product.Id);
                if (companyEntity != null)
                {
                    companyEntity.Name = product.Name;
                    companyEntity.Descripation = product.Descripation;
                    companyEntity.Image = product.Image;
                    companyEntity.NewPrice = product.NewPrice;
                    companyEntity.OldPrice = product.OldPrice;
             
                      _db.SaveChanges();
                }
            }
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
                    _db.SaveChanges();
                }
                    
            }

        }

    }
}
