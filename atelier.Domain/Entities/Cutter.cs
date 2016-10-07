using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace atelier.Domain.Entities
{
    public class Cutter
    {
        public Cutter()
        {
            Order = new List<Order>();
        }
         
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Не корректно введено Имя")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Не корректно введена Фамилия")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Не корректно введен номер телефона")]
        [Display(Name = "Номер телефон")]
        [RegularExpression(@"^([\+]?)((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,12}",
            ErrorMessage = "Не корректно введен номер телефона")]
        public string PhoneNumber { get; set; }
        public List<Order> Order { get; set; }
    }
}