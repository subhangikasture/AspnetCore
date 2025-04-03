namespace BethanysPieShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string ZipCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string? State { get; set; } //nullable
        public string Country { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public decimal OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
    }
}
