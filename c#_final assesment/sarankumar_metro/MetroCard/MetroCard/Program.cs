using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroCard
{
    class Program
    {
        private static List<Propert> user = new List<Propert>();
        static void Main(string[] args)
        {
            Program p = new Program();
            var fdata = new Propert("praveenkumar", 7598395863, 1000,"AnnaNagar-Kilpak");
            var sdata = new Propert("Yuvaraj", 9864751234, 2000,"Kilpak-CMPT");
            user.Add(fdata);
            user.Add(sdata);
            string ch;
            do
            {
                Console.WriteLine("<<------------Application for Metro Card Management---------->>");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("1.Add new user to the system \n2.Existing user services \n3.Exit");
                Console.WriteLine("Select Option---->>>");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        p.Adduser();
                        //p.Show();
                        break;
                    case 2:
                       p.Exuser();
                        break;
                    case 3:
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("Choose valid option!!!");
                        break;
                }
                Console.WriteLine("Do you want Continue (yes/no)?");
                ch = Console.ReadLine();
            } while (ch == "yes");
            Console.WriteLine("Thank you!");
            Console.ReadKey();
        }
        public void Adduser()
        {
            Console.WriteLine("======ADD NEW USER=========");
            Console.WriteLine();
            Console.WriteLine("Enter the Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Phone number:");
            long phoneNo = long.Parse(Console.ReadLine());
            Console.Write("Enter the initial recharge amount: ");
            int InitialAmount = int.Parse(Console.ReadLine());
            var data = new Propert(Name, phoneNo, InitialAmount,"");
            user.Add(data);
            Console.WriteLine("USER SUCCESSFULLY ADDED.............!");
            Console.WriteLine($"Your card No: {Propert.CardNo()}");
            

        }
        public void Exuser()
        {
            string ch;
            Console.WriteLine("Enter the Card Number:");
            int cardno = int.Parse(Console.ReadLine());
            foreach(Propert d in user)
            {
                if(d.cardNo == cardno)
                {
                    Console.Write($"Welcome Mr/Ms.{d.Name} \n");
                    Console.WriteLine("-----------------------------");
                    do
                    {
                        Console.WriteLine("1.Balance Check \n2.Recharge \n3.View Travel History \n4.Travel \n5.Go to Main Menu");
                        Console.WriteLine();
                        Console.Write("Select option--->>");
                        int opt = int.Parse(Console.ReadLine());
                        switch (opt)
                        {
                            case 1:
                                Console.WriteLine("Your Balance: " + d.InitialAmount);
                                break;
                            case 2:
                                Console.WriteLine("Enter the Amount for Recharge:");
                                int reg = int.Parse(Console.ReadLine());
                                d.InitialAmount += reg;
                                Console.WriteLine("Recharge Successfully.....!");
                                break;
                            case 3:
                                Console.WriteLine("Travel History:");
                                Console.WriteLine(d.TravelHist);
                                break;
                            case 4:
                                Console.WriteLine("Enter the Current location:");
                                string currentloc =Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("a.AnnaNagar - Rs 20 \nb.Kilpak - Rs 40");
                                Console.WriteLine("Choose the location:");
                                char lc =char.Parse( Console.ReadLine());
                                if (lc == 'a')
                                {
                                    if(d.InitialAmount >= 20)
                                    {
                                        d.InitialAmount -= 20;
                                        d.TravelHist += $"\n{ currentloc}-AnnaNagar";
                                        Console.WriteLine($"your Travel Location => {currentloc}-AnnaNagar");
                                        Console.WriteLine("Travel Booked successfully! ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Insufficiant Balance");
                                    }
                                   
                                }
                                else if (lc == 'b')
                                {
                                    if (d.InitialAmount >= 40)
                                    {
                                        d.InitialAmount -= 40;
                                        d.TravelHist += $"{currentloc}-Kilpak";
                                        Console.WriteLine($"your Travel Location => {currentloc}-Kilpak");
                                        Console.WriteLine("Travel Booked successfully! ");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Insufficiant Balance, Please Recharge!");
                                    }

                                }
                                break;
                            case 5:
                                break;
                            default:
                                Console.WriteLine("Please enter valid Option!");
                                break;

                        }
                        Console.WriteLine("Do you want Continue (yes/no)?");
                        ch = Console.ReadLine();
                    } while (ch == "yes");
                    

                }
              
            }
          

        }
       /* public void Show()
        {
            foreach(Propert all in user)
            {
                Console.WriteLine($"Name: {all.Name} \nPhoNo: {all.phoneNo} \nInitialAmount: {all.InitialAmount}");
            }
        }*/
    }

    
}
