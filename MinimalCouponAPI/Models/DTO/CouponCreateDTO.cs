using System.ComponentModel.DataAnnotations;

namespace MinimalCouponAPI.Models.DTO
{
    public class CouponCreateDTO
    {
        
        public string Name { get; set; }
        public int Percent { get; set; }
        public bool IsActive { get; set; }
    }
}
