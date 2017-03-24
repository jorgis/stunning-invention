using System;
using System.ComponentModel.DataAnnotations;

namespace Webapp.Models
{
    public class BirthCertificateInputModel
    {
        [Required]
        [Display(Name = "Fullt navn")]
        public string Name {get; set;}

        [Required]
        [Display(Name = "Forelder 1")]
        public string Parent1 {get; set;}

        [Required]
        [Display(Name = "Forelder 2")]
        public string Parent2 {get; set;}

        [Required]
        [Display(Name = "Personnummer")]
        public string PersonNummer {get; set;}
        
        [Display(Name = "Fødselsdato")]
        public string BirthDate {get; set;}

        [Display(Name = "Biometridata el. andre opplysninger")]
        [DataType(DataType.MultilineText)]
        public string Biometry {get; set;}
    }
}