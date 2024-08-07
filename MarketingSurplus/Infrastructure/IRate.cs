﻿using MarketingSurplus.Models;

namespace MarketingSurplus.Infrastructure
{
    public interface IRate
    {
        public Rate GetRate(int id);
        public List<Evalution> GetRates(int companyId);
        public void Save(Rate rate, int subId);
        public void Delete(int id);
        public void Update(Rate rate);
    }
}
