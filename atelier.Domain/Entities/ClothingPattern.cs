using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace atelier.Domain.Entities
{
    public class ClothingPattern
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Не корректно введено название")]
        [Display(Name = "Название модели")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не корректно введен код")]
        [Display(Name = "Уникальный код")]
        public int Code { get; set; }
        [Required(ErrorMessage = "Не корректно введена цена")]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public string ImageType { get; set; }
        public Cloth Cloth { get; set; }
        public int ClothId { get; set; }
    }
}