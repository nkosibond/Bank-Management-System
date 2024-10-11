using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2781_PROJECT
{
    public interface LoanConstantsInterface
    {
        string CompanyName { get; }
        int MaxLoanAmount { get; }
        int ShortTerm { get; }
        int MediumTerm { get; }
        int LongTerm { get; }
    }
}
