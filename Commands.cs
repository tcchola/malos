using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosmosKernel1;
using System.IO;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem;

namespace CosmosKernel1
{

    public class Commands
    {
        private CosmosVFS fs;
        Apps app = new Apps();
        public void Command()
        {
            this.fs = new CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(this.fs);
            string fileName = Console.ReadLine();
            string folderName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine();

            if( input=="help" || input == "HELP" )
            {
                Console.WriteLine("You can type 'help' anytime to get to this menu.");
                Console.WriteLine("The system uses commands and arguments to run tasks.");
                Console.WriteLine("You can type 'programName -info' to show the program's description.");
                Console.WriteLine("Type 'cmd -list' for a list of all commands and their descriptions.");
                Console.WriteLine("Type 'argument -list' for a list of all flags and their descriptions.");
                Console.WriteLine("You can type 'sys -info' anytime to see more about the system.");
            }
            else if( input == "clear" || input == "CLEAR") 
            {
                Console.Clear();
            }
            // sistemske komande
            else if (input == "sys -info" || input == "SYS -INFO")
            {
                Console.WriteLine("Name: Mali Operativni Sistem");
                Console.WriteLine("Version: 0.0.1");
                Console.WriteLine("Description: Console-based operativni sistem sa aplikacijama gradjen u C# kroz COSMOS kit.");
                Console.WriteLine("Author: Tarik Colic");
                Console.WriteLine("Skola: Srednja elektrotehnicka skola Mostar");
            }
            else if (input == "sys -shutdown" || input == "SYS -SHUTDOWN")
            {
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Cosmos.System.Power.Shutdown();
            }
            else if (input == "sys -reboot" || input == "SYS -REBOOT")
            {
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Cosmos.System.Power.Reboot();
            }
            // aplikacijske komande
            else if (input == "apps -list" || input == "APPS -LIST")
            {
                Console.WriteLine("Calculator");
                Console.WriteLine("Clock");
            }
            else if (input == "run calculator" || input == "RUN CALCULATOR")
            {
                app.Calculator();
            }
            else if (input == "run clock" || input == "RUN CLOCK")
            {
                app.Clock();
            }
            // filesys komande
            else if (input == "file -make " + fileName || input == "FILE -MAKE " + fileName)
            {
                //
            }
            else if(input == "folder -make " + folderName || input == "FOLDER -MAKE " + folderName)
            {
                //
            }
            // poruka za nepoznate komande
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unknown command " + "'" + input + "'" + ".");
            }
        }
    }
}
