using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmission
{
    public enum Dept
    {
        CES = 1, IT=2, ECE=3, EEE=4
    }
    class Admission
    {

        private static int IT = 3;
        private static int CSE = 3;
        private static int ECE = 3;
        private static int EEE = 3;
             
        private static int increment = 100;
       
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string SchoolName { get; set; }

        public int Mark { get; set; }
        public Dept ReqDept { get; set; }

        public Admission(  string name,string address,string sclname,int mark, Dept Reqdept)
        {
            
            
            Name = name;
            this.Address = address;
            this.SchoolName = sclname;
            this.Mark = mark;
            this.ReqDept = Reqdept;
            this.StudentID = increment;
            increment++;
            
            if(ReqDept == (Dept)1)
            {
                if(CSE != 0)
                {
                    CSE -= 1;
                    
                }
        
            }
            else if(ReqDept == (Dept)2)
            {
                if (IT != 0)
                {
                    IT -= 1;
                   
                }
               
            }
            else if(ReqDept == (Dept)3)
            {
                if (ECE != 0)
                {
                    ECE -= 1;
                
                }
              

            }
            else if(ReqDept == (Dept)4)
            {
                if (EEE != 0)
                {
                    EEE -= 1;
                 
                }
              
            }

            

        }
        public static (int, int, int, int) Countavail()
        {
            return (CSE, IT, ECE, EEE);
        }

    }
}
