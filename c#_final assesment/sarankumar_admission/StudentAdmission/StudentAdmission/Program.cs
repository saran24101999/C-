using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StudentAdmission
{
    class Program
    {

       private static List<Admission> admission_details = new List<Admission>();
        static void Main(string[] args)
        {
            Program fetch = new Program();
 
            string userchoice;
            do
            {
                Console.WriteLine("                                   Welcome to SNS college of Technology  ");
                Console.WriteLine("1.Student Admission       2.Department wise sheet availability        3.Student Details      4.Show All      5.Exit");
                Console.WriteLine("Choose the field:");
                int given = int.Parse(Console.ReadLine());

                switch (given)
                {
                    case 1:
                        fetch.StudentAdmission();
           
                        break;
                    case 2:
                        fetch.Sheetavailable();
                      
                        break;
                    case 3:
                        fetch.StudentDetails();
                        break;
                    case 4:
                        fetch.Show();
                        break;
                    case 5:
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
                Console.WriteLine("If you want to continue press yes");
                userchoice = Console.ReadLine();
            } while (userchoice == "yes");
            Console.ReadKey();
        
        }

        public void StudentAdmission()
        {
            Console.WriteLine("               Student Admission");
            Console.WriteLine("Enter the Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Address:");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter the School Name:");
            string SchoolName = Console.ReadLine();
            Console.WriteLine("Enter the mark in percentage:");
            int Mark = int.Parse(Console.ReadLine());
            Console.WriteLine("Requested Departments:\n");
            Console.WriteLine("1.CSE     2.IT      3.ECE       4.EEE");
            Console.WriteLine("Choose the Department:");
            Dept ReqDept =(Dept)int.Parse( Console.ReadLine());
                     
            (int CSE, int IT, int ECE, int EEE) = Admission.Countavail();
            if(ReqDept == (Dept)1)
            {
                if(CSE != 0)
                {
                    var data = new Admission(Name, Address, SchoolName, Mark, (Dept)ReqDept);
                    admission_details.Add(data);
                    Console.WriteLine("Admission Successfully Registered");
                }
                else
                {
                    Console.WriteLine("No sheets are available");
                }
            }
            else if (ReqDept == (Dept)2)
            {
                if (IT != 0)
                {
                    var data = new Admission(Name, Address, SchoolName, Mark, (Dept)ReqDept);
                    admission_details.Add(data);
                    Console.WriteLine("Admission Successfully registered");
                }
                else
                {
                    Console.WriteLine("No sheets are available");
                }
            }
            else if (ReqDept == (Dept)3)
            {
                if (ECE != 0)
                {
                    var data = new Admission(Name, Address, SchoolName, Mark, (Dept)ReqDept);
                    admission_details.Add(data);
                    Console.WriteLine("Admission Successfully registered");
                }
                else
                {
                    Console.WriteLine("No sheets are available");
                }
            }
            else if (ReqDept == (Dept)4)
            {
                if (EEE != 0)
                {
                    var data = new Admission(Name, Address, SchoolName, Mark, (Dept)ReqDept);
                    admission_details.Add(data);
                    Console.WriteLine("Admission Successfully Registered");
                }
                else
                {
                    Console.WriteLine("No sheets are available");
                }
            }


        }
        public void Sheetavailable()
        {
            (int CSE, int IT, int ECE, int EEE) = Admission.Countavail();
            Console.WriteLine("               Department sheet availability");
            Console.WriteLine($"1.CSE:{CSE}      2.IT:{IT}      3.ECE:{ECE}     4.EEE:{EEE} ");
            Console.WriteLine("Know more about Department");
            string datas;
            
                do
                {
                    Console.WriteLine("Choose your Dept:");
                    int ch1 = int.Parse(Console.ReadLine());
                    switch (ch1)
                    {
                        case 1:

                            foreach (Admission dt in admission_details)
                            {
                                if (dt.ReqDept == (Dept)1)
                                    Console.WriteLine($"Student ID: {dt.StudentID} \n Name: {dt.Name}");
                            }
                            break;
                        case 2:
                            foreach (Admission dt in admission_details)
                            {
                                if (dt.ReqDept == (Dept)2)
                                    Console.WriteLine($"Student ID: {dt.StudentID} \n Name: {dt.Name}");
                            }
                            break;
                        case 3:
                            foreach (Admission dt in admission_details)
                            {
                                if (dt.ReqDept == (Dept)3)
                                    Console.WriteLine($"Student ID: {dt.StudentID} \n Name: {dt.Name}");
                            }
                            break;
                        case 4:
                            foreach (Admission dt in admission_details)
                            {
                                if (dt.ReqDept == (Dept)4)
                                    Console.WriteLine($"Student ID: {dt.StudentID}  \n Name: {dt.Name}");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                    Console.WriteLine("Press yes for continue");
                    datas = Console.ReadLine();

                } while (datas == "yes");
               
        }
        public void StudentDetails()
        {
            Console.WriteLine("             Student Details");
            Console.WriteLine();
            Console.WriteLine("Enter the Student ID:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine();
            foreach (Admission dt in admission_details)
            {
               
                if (dt.StudentID == id)
                Console.WriteLine($"Student ID: {dt.StudentID} \n Name: {dt.Name} \nAddress: {dt.Address} \nSchool Name: {dt.SchoolName} \nMark: {dt.Mark} \nDepartment: {dt.ReqDept}");
            }

        }

        public void Show()
        {
            foreach (Admission dt in admission_details)
            {
                Console.WriteLine("                     ALL STUDENT DETAILS");
                Console.WriteLine($"Student ID: {dt.StudentID} \n Name: {dt.Name} \nAddress: {dt.Address} \nSchool Name: {dt.SchoolName} \nMark: {dt.Mark} \nDepartment: {dt.ReqDept}");
                Console.WriteLine();
                

            }

        }
    }
}
