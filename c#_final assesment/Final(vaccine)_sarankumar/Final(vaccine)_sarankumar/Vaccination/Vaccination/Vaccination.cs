using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination
{
    //
    public enum VaccineType
    {
        CovidShield = 1,
        Covaccine=2, 
        Sputnick=3
    }
    
    class Vaccination
    {
        //vactination type
        public VaccineType type { get; set; }
       
        public int Dose { get; set; }
        public DateTime VaccinatedDate { get; set; }

        
        public Vaccination(VaccineType vaccintype, DateTime vacinDate)
        {
            type = vaccintype;
            VaccinatedDate = vacinDate;
        }

    }
}
