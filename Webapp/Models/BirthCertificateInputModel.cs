using System;

namespace Webapp.Models
{
    public class BirthCertificateInputModel
    {
        string PersonNummer {get;set;}
        
        DateTime BirthDate {get; set;}

        string Biometry {get;set;}
    }
}