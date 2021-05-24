##GlobalX Assesment##

This software sorts a list of names from a .txt file alphabetically with last names as a primary then given names as a secondary.  

Software was created on Windows 10, and has been tested on a Linux mint.

Software contains unit tests that tests txt file import and sort. This has also been tested on Travis CI.

##System requirements##

Software was created on Windows 10 and needs dotnet installed to PATH

##Running the Software##

1. Copy .txt file that has a list of names to ./Name-sorter/Name-Sorter folder
2. Open terminal and cd to ./Name-sorter/Name-Sorter folder
3. type "dotnet build" - this build the software
4. type "dotnet run [enter name of file here].txt" - runs software; i.e. dotnet run 1000names.txt