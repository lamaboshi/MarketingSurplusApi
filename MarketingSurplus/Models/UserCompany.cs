﻿namespace MarketingSurplus.Models
{
    public class UserCompany
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<UserCompanyRate> UserCompanyRates { get; set; }
    }
}
