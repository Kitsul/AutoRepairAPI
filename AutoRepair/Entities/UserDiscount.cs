using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRepair.Entities
{
    [Table("YK_UserDiscount")]
    public class UserDiscount
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
    }
}
