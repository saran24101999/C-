using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Program
    {
        private static List<Propet> library = new List<Propet>();
        
        static void Main(string[] args)
        {
            Program p = new Program();
            var book1 = new Propet("book1", "", 0, DateTime.Now);
            var book2 = new Propet("book2", "", 0, DateTime.Now);
            var book3 = new Propet("book3", "saran", 7010760460, DateTime.Now.AddDays(4));
            var book4 = new Propet("book4", "kumar", 7556789788, DateTime.Now.AddDays(6));
            var book5 = new Propet("book5", "Ram", 98374478888, DateTime.Now.AddDays(8));
            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
            library.Add(book4);
            library.Add(book5);

            string userchoice;
            do
            {
                Console.WriteLine("Welcome to Library ");
                Console.WriteLine("1.Search for book availability \n2.issue & Track Book");
                Console.Write("Option");
                int other = int.Parse(Console.ReadLine());
                switch (other)
                {
                    case 1:
                        p.SearchBook();
                       
                        break;
                    case 2:
                        p.IssueTrack();
                       
                        break;
                    default:
                        Console.WriteLine("Choose the correct option!");
                        break;


                }
                Console.Write("if you want Continue (yes/no)?");
                userchoice = Console.ReadLine();
            } while (userchoice == "yes");

        }
        public void SearchBook()
        {
            Console.Write("Enter the Book Name:");
            string bname = Console.ReadLine();
            int count = 0;
            foreach(Propet data in library)
            {
                if(data.BookName == bname)
                {
                    Console.WriteLine("The book is Available in the library");
                    count = 0;
                    break;
                }
                else
                {
                    count++;
                }
            }
            if(count > 0)
            {
                Console.WriteLine("The book not  available in the library");
            }

        }
        public void IssueTrack()
        {
            Console.WriteLine("Enter the Book Name:");
            string bname = Console.ReadLine();
            foreach (Propet dt in library)
            {
                if(dt.BookName == bname && dt.MemberName == "")
                {
                    Console.WriteLine("Enter the Member Name:");
                    string mname = Console.ReadLine();
                    Console.WriteLine("Enter the Member Number:");
                    long mnumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Date:");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    dt.MemberName = mname;
                    dt.MemberPhoNum = mnumber;
                    dt.IssueDate = date;
                    Console.WriteLine();
                    Console.WriteLine("Book was Taken");
                    Console.Write("Details:");
                    Console.WriteLine($"Book Name: {dt.BookName} \nMember Name: {dt.MemberName} \nMember PhoneNumber: {dt.MemberPhoNum} \nIssuedData: {dt.IssueDate}");

                }
                else if(dt.BookName == bname && dt.MemberName != "")
                {
                    Console.WriteLine("Book was already issued.........! \n Details: ");
                   
                    Console.Write($"BookName: {dt.BookName} \nMemmber Name: {dt.MemberName} \nMember PhoneNo: {dt.MemberPhoNum} \nIssued Date: {dt.IssueDate}");

                }
            }
        }
        public void Show()
        {
            foreach(Propet all in library)
            {
                Console.WriteLine($"BookName: {all.BookName} \nMemmber Name: {all.MemberName} \nMember PhoneNo: {all.MemberPhoNum} \nIssued Date: {all.IssueDate}");
            }
        }
    }
}
