using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JaskiniaGier.Models.Entities
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        public List<OrderItems> OrderItems { get; set; }
        
        [Required(ErrorMessage = "Wpisz swoje imię!")]
        [StringLength(50)]
        [Display(Name = "Imię:")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Wpisz swoje nazwisko!")]
        [StringLength(50)]
        [Display(Name = "Nazwisko:")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Wpisz nazwę ulicy!")]
        [StringLength(50)]
        [Display(Name = "Ulica:")]
        public string Address1 { get; set; }

        [Required(ErrorMessage = "Wpisz numer domu/lokalu!")]
        [StringLength(50)]
        [Display(Name = "Nr domu/lokalu:")]
        public string Address2 { get; set; }

        [Required(ErrorMessage = "Wpisz kod pocztowy!")]
        [StringLength(6)]
        [Display(Name = "Kod pocztowy:")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Wpisz miejscowość!")]
        [StringLength(50)]
        [Display(Name = "Miejscowość:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Wpisz numer kontaktowy!")]
        [StringLength(9)]
        [Display(Name = "Nr telefonu:")]
        public string PhoneNumber { get; set; }

        [BindNever]
        [NotMapped]
        public decimal OrderTotal { get; set; }

        [BindNever]
        public string OrderPlaced { get; set; }


        public string UserId { get; set; }
      
        
    }
}
