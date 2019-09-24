using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaEval.Models
{
    public enum TypeContact
    {
        PhoneNumber,
        Email,
        FaceBook,
        Twitter,
        PornHub,
    }
    public class Phone
    {
        [Key]
        public int PhoneID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TypeContact Type { get; set; }
        [Required]
        public string Contact { get; set; }
    }
    
}