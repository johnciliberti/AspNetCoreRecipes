using System;
using System.ComponentModel.DataAnnotations;

namespace Recipe01.ViewModels
{
    public class TShirtViewModel
    {
        [ScaffoldColumn(false)]
        [Key]
        public int TShirtId { get; set; }

        [Display(Name ="Start selling this item on:", Order = 3)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        [DataType(DataType.Date)]
        public DateTime SaleStartDate { get; set; } = DateTime.Now;

        [Display(Name = "Stop selling this item on:", Order = 4)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        [DataType(DataType.Date)]
        public DateTime SaleEndDate { get; set; } = DateTime.Now.AddDays(7);

        [Required]
        [Display(Name ="T-Shirt Name", Order = 1)]
        [StringLength(30, MinimumLength = 6, ErrorMessage ="T-Shirt Name must have at least 6 characters but no more then 30." )]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "The T-Shirt name can only contain letters")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "T-Shirt Description", Order = 2)]
        [DataType(DataType.MultilineText)]
        [StringLength(255, MinimumLength = 6, ErrorMessage = "Description must have at least 6 characters but no more then 255.")]
        public string Description { get; set; }

        [Required]
        [Range(5,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; } = 5;

        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string SellerEmailAddress { get; set; }

        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [Compare("SellerEmailAddress")]
        public string ConfirmEmailAddress { get; set; }

        [Required]
        [Display(Name ="Accept to the terms and conditions.")]
        // The below will not work
        //[Range(typeof(bool), "true", "true", ErrorMessage = "You must accept the terms and conditions.")]
        public bool AgreeToTermsAndConditions { get; set; } = true;


    }
}
