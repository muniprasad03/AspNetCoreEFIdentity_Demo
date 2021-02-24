using System.ComponentModel.DataAnnotations;

namespace AspNetCoreEFIdentity.Models
{
    public class TwoFactor
    {
        [Required]
        public string TwoFactorCode { get; set; }
    }
}
