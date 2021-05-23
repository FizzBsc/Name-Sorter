using System;
using System.Collections.Generic;
using System.IO;

namespace Name_Sorter
{
    public class FileExport
    {
        public static void exportNames(List<Name> name)
        {
            try
            {
                using (System.IO.StreamWriter file = new StreamWriter("sorted-names-list.txt"))
                {
                    foreach (Name fullname in name)
                    {
                        file.WriteLine(fullname);
                    }
                }

            }
            catch (IOException)
            {
                Console.Error.WriteLine("Unable to write to the file.");
            }

        }
    }
}
