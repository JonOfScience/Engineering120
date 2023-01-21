using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindData;

public partial class Customer
{
    // Anything I add here will be included in the Customer class at compile time
    public override string ToString()
    {
        return $"{CustomerId} {ContactName} {CompanyName}";
    }
}
