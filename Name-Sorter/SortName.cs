using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Name_Sorter
{
    public class SortName
    {
        public static List<Name> sort(List<Name> list)
        {
            return list.OrderBy(name => name.lastName)
                .ThenBy(name => name.givenNames)
                .ToList();
        }
    }
}
