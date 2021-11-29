using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination
{
    //enum type
    public enum Gender
    {
        male=1,female=2,others=3
    }
    class beneficiery
    {

        private static int inc = 1001;
        // user id details
        public int regnum { get; set; }
        public string Name { get; set; }
        public long Number { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        
        //Vaccination list
        public List<Vaccination> VaccineDetails
        {
            get;set;
        }
       
        //user details
        public beneficiery(string name,long number,string city,int age,Gender gender)
        {
            Name = name;
            Number = number;
            City = city;
            Age = age;
            Gender = gender;
            regnum = inc++;
           
            
        }
        

        public void VaccinDetails(int regNo)
        {

            if (this.regnum == regNo)
            {
                if (VaccineDetails != null)
                {

                    foreach (Vaccination dt in VaccineDetails)
                    {
                        Console.WriteLine("\nYour Vaccinated dose  : {0}", dt.type);
                        Console.WriteLine("\nVaccinated Date: {0}", dt.VaccinatedDate);
                    }
                }
            }

        }
        
        public void VaccineDueDate(int regNo)
        {
            if(regnum == regNo)
            {
                if (VaccineDetails != null)
                {

                    foreach (Vaccination dt in VaccineDetails)
                    {
                        if (VaccineDetails.Count == 1)
                        {
                            Console.WriteLine("\nVaccinated dose by : {0}", dt.type);
                            Console.WriteLine("\nVaccinated Date: {0}",dt.VaccinatedDate.AddDays(30));

                        }
                        else if (VaccineDetails.Count == 2)
                        {
                            Console.WriteLine("\nYour vaccination course has completed. \n");
                            break;
                        }


                    }
                }
            }

        }
    }
}
