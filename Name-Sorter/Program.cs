using System;

namespace Name_Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("Please specify a filename as a parameter.");
                return;
            }
            // 1) read file
            var filename = args[0];
            // 2) process file to object class
            // 3) add contents of file to array
            var list = FileImport.importNames(filename);
            // 4) sort array
            var sort = SortName.sort(list);
            // 5) print array 
            foreach (Name name in sort)
            {
                Console.WriteLine(name.ToString());
            }
            // 6) save array to file
            FileExport.exportNames(sort);
        }
    }
}
