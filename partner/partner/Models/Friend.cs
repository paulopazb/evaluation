

namespace partner.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Friend
    {
        public enum TypeName
        {
            Paulo,
            Pepe,
            Pablo,
            Pascual,
            Priscila,
        }
        [Key]
        public int FriendId { get; set; }
        [Required]
        [Display(Name = "Nombre Completo")]
        [MinLength(5, ErrorMessage = "Name cannot be less than 2 characters")]
        [MaxLength(50, ErrorMessage = "Name cannot be more than 30 characteres")]
        public string Name { get; set; }
        public TypeName List { get; set; }
        public string Mail { get; set; }
        [Display(Name = "Cumpleaños")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

    }
}