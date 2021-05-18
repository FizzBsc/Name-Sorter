using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Name_Sorter
{
    //reads name from file and adds to an array(unsorted)
    public class FileImport
    {

        public static List<Name> importNames(string filename)
        {
            var fullName = new List<Name> { };
            string invalidFileMessage = "The given file was not valid";
            //read names from file added to array
            string[] readNames;
            try
            {
                readNames = File.ReadAllLines(filename);
            }
            catch (Exception e)
            {
                throw new InvalidFileException(invalidFileMessage, e);
            }
            // parse array to Name class
            for (int i = 0; i < readNames.Length; i++)
            {
                var name = readNames[i];
                // Console.WriteLine(i+readNames[i]);

                // Split string into given and last names
                int lastGiven = name.LastIndexOf(' ');
                if (lastGiven < 1)
                {
                    throw new InvalidFileException(invalidFileMessage);
                }
                var firstNames = name.Substring(0, lastGiven);
                var lastName = name.Substring(lastGiven + 1);

                fullName.Add(new Name(firstNames, lastName));
            }
            return fullName;
        }

    }
}
