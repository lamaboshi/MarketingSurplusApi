using MarketingSurplus.Dto;
using MarketingSurplus.Models;

namespace MarketingSurplus.Infrastructure
{
    public interface IMain
    {
        List<CompnyProductDto> GetAllPosts(int userId);
        List<CompnyProductDto> GetSubscriptionPosts(int id);
        List<CompanyProduct> GetAllCompanyProduct(int companyId);
        int SaveOrder(SaveOrderRequestDto request);
        void UpdateStutasOrder(int idOrder, int Stutas);
        void AddCompanyProduct(SaveCompanyProduct saveCompany);

        List<OrderDto> GetOrderDetails(int idOrder);
    }
}
