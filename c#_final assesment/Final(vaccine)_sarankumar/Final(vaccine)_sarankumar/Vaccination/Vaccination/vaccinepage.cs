using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination
{

    
    class CovidVaccination
    {
        
       
        private static List<beneficiery> vacinelist = new List<beneficiery>();
        static void Main(string[] args)
        {
            string userchoice;
            CovidVaccination vaccinecall = new CovidVaccination();

           
            do
            {
                Console.WriteLine("                                   Welcome to Vaccination Drive\n");
                Console.WriteLine("                    1.Beneficiery Registration       2.Vaccination        3.Exit\n\n");
                Console.WriteLine("                                       Choose one to enter");
                int given = int.Parse(Console.ReadLine());

                switch (given)
                {
                    case 1:
                        vaccinecall.beneficieryRegistration();
                       
                        break;
                    case 2:
                        vaccinecall.Vaccine();
                       
                        break;
                    case 3:
                        Environment.Exit(-1);
                        break;

                }
                Console.WriteLine("Do you want continue enter : yes/no ");
                userchoice = Console.ReadLine();
            } while (userchoice == "yes");

        }
  
        public void beneficieryRegistration()
        {

            Console.WriteLine("  name:");
            string Name = Console.ReadLine();
            Console.WriteLine("  Phono:");
            long PhoneNo = long.Parse(Console.ReadLine());
            Console.WriteLine("  City:");
            string City = Console.ReadLine();
            Console.WriteLine("  Age:");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("  1.Male   2.Female   3.Transgender");
            Gender Gender =(Gender)int.Parse(Console.ReadLine());
            beneficiery add = new beneficiery(Name, PhoneNo, City, Age, Gender);
            vacinelist.Add(add);
            Console.WriteLine("                             Registration Successfully\n");
            Console.WriteLine("                             User Registration id: " + add.regnum);
        }
     
        public void Vaccine()
        {
            string choice;
            Console.Write("\nEnter the Register id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine();
            foreach (beneficiery data in vacinelist)
            {
                if (id == data.regnum)
                {
                    do
                    {
                        
                        Console.WriteLine("1.Take Vaccination     2.Vaccination History      3.Next Due Date          4.Exit\n");
                        Console.Write("Choose One\n");
                        
                        int option = int.Parse(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                
                                Console.WriteLine("1.Covid-Shield   2.Covaccine    3.sputnick\n");
                                Console.WriteLine("Which type vaccine do you prefer?\n");
                                VaccineType vacType = (VaccineType)int.Parse(Console.ReadLine());

                                Vaccination user = new Vaccination(vacType, DateTime.Now);
                                if (data.VaccineDetails == null)
                                {

                                    data.VaccineDetails = new List<Vaccination>();
                                }
                                data.VaccineDetails.Add(user);
                                
                                Console.WriteLine("Successfully vaccinated.\n");

                                break;
                            case 2:                               
                                foreach (beneficiery history in vacinelist)
                                {
                                    if (history.VaccineDetails != null)
                                    {
                                        
                                        history.VaccinDetails(id);                                       
                                    }
                                }

                                break;
                            case 3:
                                foreach (beneficiery Duedate in vacinelist)
                                {
                                    
                                    Duedate.VaccineDueDate(id);
                                }
                                break;
                            case 4:                             
                                Environment.Exit(-1);
                                break;
                            default:
                                Console.WriteLine("Invalid option choose right one\n");
                                break;

                        }
                        Console.WriteLine("Do you want continue enter : yes/no \n");
                        choice = Console.ReadLine();

                    } while (choice == "yes");
                    
                }
               

            }
           
            
        }
    }
}
