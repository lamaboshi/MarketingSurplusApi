﻿namespace MarketingSurplus.Models
{
    public class CompanyType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public ICollection<Company> Companies { get; set; }
    }
}
