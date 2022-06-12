using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sys = Cosmos.System;
using CosmosKernel1;  // koristim namespace CosmosKernel1 za klasu Commands u Commands.cs fajlu
using Cosmos.System.FileSystem;
namespace CosmosKernel1
{
    public class Kernel : Sys.Kernel
    {
        // importi metoda & aplikacija
        private CosmosVFS fs;
        Commands cmds = new Commands();
        Apps app = new Apps();
        
        // startup screen
        protected override void BeforeRun()
        {
            this.fs = new CosmosVFS();

            Console.WriteLine(" ****     ****            **   *******    ********");
            Console.WriteLine("/**/**   **/**           /**  **/////**  **////// ");
            Console.WriteLine("/**//** ** /**  ******   /** **     //**/**       ");
            Console.WriteLine("/** //***  /** //////**  /**/**      /**/*********");
            Console.WriteLine("/**  //*   /**  *******  /**/**      /**////////**");
            Console.WriteLine("/**   /    /** **////**  /**//**     **        /**");
            Console.WriteLine("/**        /**//******** *** //*******   ******** ");
            Console.WriteLine("//         //  //////// ///   ///////   ////////\n") ;
            Console.WriteLine("Type 'help' for the help menu.\n\n");
        }

        protected override void Run()
        {
            

            Console.Write(">");  // indikator da korisnik trnutno unosi komandu
            cmds.Command();  // pokrece switch-case listu za moguce komande
        }
    }
}
