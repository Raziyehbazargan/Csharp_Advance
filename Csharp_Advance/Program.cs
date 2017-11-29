using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Csharp_Advance.AccessModifier;
using Csharp_Advance.Composition;
using Csharp_Advance.Inheritance;

namespace Csharp_Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance
            var text = new Text();
            text.Copy();
            text.Duplicate();


            //Composition
            var dbMigrator = new DbMigrator(new Logger());
            var installer = new Installer(new Logger());

            dbMigrator.Migrate();
            installer.Install();


            // Access Modofiers
            Customer customer = new Customer();
            
        }
    }
}
