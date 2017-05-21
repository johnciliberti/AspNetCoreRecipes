using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recipe03.Models
{
    public class HotelReservation : IValidatableObject
    {
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name="End Date")]
        public DateTime EndDate { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Room Number")]
        [Range(1,250)]
        public int RoomNumber { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(EndDate.CompareTo(StartDate)<= 0)
            {
                yield return new ValidationResult("The end date must be after the start date.");
            }
        }
    }
}
