using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using atelier.Domain.Concrete;

namespace atelier.Domain.Entities
{
    public class Order
    {
        public Order()
        {
            Status = Status;
            BeginDate = DateTime.Now;
            EndDate = DateTime.Now;
            FittingDate = DateTime.Now;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Не корректно введена дата начала")]
        [Display(Name = "Дата начала")]
        public DateTime BeginDate { get; set; }
        [Required(ErrorMessage = "Не корректно введена дата окончания")]
        [Display(Name = "Дата окончания")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Не корректно введена дата примерки")]
        [Display(Name = "Дата примерки")]
        public DateTime FittingDate { get; set; }   
        public int ClientId { get; set; }
        public ApplicationUser Users { get; set; }
        public Cutter Cutter { get; set; }
        public int CutterId { get; set; }
        public Status Status { get; set; }
        public Cloth Cloth { get; set; }
        public int ClothId { get; set; }
        public ClothingPattern ClothingPattern { get; set; }
        public int ClothingPatternId { get; set; }
    }
}