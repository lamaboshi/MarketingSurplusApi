using MarketingSurplus.Dto;
using MarketingSurplus.Models;

namespace MarketingSurplus.Infrastructure
{
    public interface IMain
    {
        List<CompnyProductDto> GetAllPosts(int userId);
        List<CompnyProductDto> GetSubscriptionPosts(int id);
        List<CompanyProduct> GetAllCompanyProduct(int companyId);
        int SaveOrder(Order order);
        void SaveOrderProduct(OrderProduct orderProduct);
        void UpdateStutasOrder(int idOrder, int Stutas);
        void AddCompanyProduct(SaveCompanyProduct saveCompany);
        List<User> GetAllCompanyUsers(int companyId);
        List<OrderProduct> GetOrderDetails(int userId);
        List<OrderProduct> GetOrderDetailsForCompany(int companyId);
        
    }
}
