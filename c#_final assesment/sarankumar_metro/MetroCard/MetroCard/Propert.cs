using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroCard
{
    class Propert
    {
        private static int count = 101;
        public Propert(string name,long phno,int inamount,string travhis)
        {
            this.Name = name;
            this.phoneNo = phno;
            this.InitialAmount = inamount;
            this.cardNo = count++;
            this.TravelHist = travhis;
        }

        public  int cardNo;
        public string Name { get; set; }

        public long phoneNo { get; set; }
        public string TravelHist { get; set; }

        private  int _initialAmount=0 ;

        public int InitialAmount
        {
            get
            {
                return _initialAmount;

            }
            set
            {
                if(value > 0)
                {
                    _initialAmount = value;
                    return;
                }
                else
                {
                    _initialAmount = 0;
                }
            }
        }
        public static int CardNo()
        {
            return count;
        }
           
    }

}
