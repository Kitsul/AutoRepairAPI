namespace AutoRepair.Entities
{
    public class UserDiscount
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
    }
}
