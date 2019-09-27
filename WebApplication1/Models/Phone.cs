using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public enum TypeContact
    {Facebook,
        Email,
        PornHub,
    }
    
    public class Phone
    {
        [Key]
        public int PhoneID { get; set; }
        [Required]
        public TypeContact Type { get; set; }
    }
}