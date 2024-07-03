namespace MarketingSurplus.Models
{
    public class Charity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[]? Image { get; set; }
        public byte[]? QRCode { get; set; }
        public string? Address { get; set; }
        public string AssociationLicense { get; set; }
        public string TargetGroup { get; set; }
        public bool isAccept { get; set; }
        public string Goals { get; set; }
    }
}
