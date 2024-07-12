﻿namespace MarketingSurplus.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string? OnlineImage { get; set; }
        public byte[]? Image { get; set; }
        public byte[]? QRCode { get; set; }
        public string? Address { get; set; }
        public string PayPal { get; set; }
        public bool isAccept { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public ICollection<Subscription>? Subscriptions { get; set; }
    }
}
