using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace atelier.Domain.Entities
{
    public class Cloth
    {
        public Cloth()
        {
            ClothingPattern = new List<ClothingPattern>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Не корректно введено название")]
        [Display(Name = "Название ткани")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не корректно введен код")]
        [Display(Name = "Уникальный код")]
        public int Code { get; set; }
        [Required(ErrorMessage = "Не корректно введена ширина")]
        [Display(Name = "Ширина ткани")]
        public double Widht { get; set; }
        [Required(ErrorMessage = "Не корректно введена длина")]
        [Display(Name = "Длина ткани")]
        public double Length { get; set; }
        [Required(ErrorMessage = "Не корректно введена цена")]
        [Display(Name = "Цена ткани")]
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public string ImageType { get; set; }
        [Required(ErrorMessage = "Не корректна введена страна изготовителя")]
        [Display(Name = "Страна изготовителя")]
        public string Country { get; set; }
        public List<ClothingPattern> ClothingPattern { get; set; }
    }
}