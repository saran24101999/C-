using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Propet
    {
        public Propet(string bookname,string membername,long membernum,DateTime issudate)
        {
            this.BookName = bookname;
            this.MemberName = membername;
            this.MemberPhoNum = membernum;
            this.IssueDate = issudate;
        }
        public string BookName { get; set; }
        public string MemberName { get; set; }

        public long MemberPhoNum { get; set; }
        public DateTime IssueDate { get; set; }
    }
}
