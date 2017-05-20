using Recipe02.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace Recipe02.Models
{
    public class SoftwareLicenceAgreementModel
    {
        [Required]
        public string AgreementText { get; set; } = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ille incendat? 
Duo Reges: constructio interrete. 
Quae ista amicitia est? Quare conare, quaeso. 
Negat enim summo bono afferre incrementum diem.Hoc simile tandem est? Quod equidem non reprehendo; Non potes, nisi retexueris illa.
Erat enim Polemonis. Et nemo nimium beatus est; Quid de Pythagora?
Eam stabilem appellas.Age sane, inquam.Stoici scilicet. 
Dat enim intervalla et relaxat.Tibi hoc incredibile, quod beatissimum.";

        [StringLength(50)]
        public string SoftwareProductName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Licensee Name")]
        public string LicenseeName { get; set; }

        [ConfirmValue(true, ErrorMessage = "Please accept the licensing agreement")]
        [Display(Name = "Agreement Accepted")]
        public bool AgreementAccepted { get; set; }
    }
}
