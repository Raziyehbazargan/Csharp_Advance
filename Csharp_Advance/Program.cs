using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Csharp_Advance.AccessModifier;
using Csharp_Advance.Composition;
using Csharp_Advance.ConstructorInheritance;
using Csharp_Advance.Upcasting_Downcasting;
using Text = Csharp_Advance.Inheritance.Text;

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


            //Constructor Inheritance
            Car car = new Car("45To4");

            //Upcasting : you can simply convert an object reference to its base class reference.
            Text text = new Text();
            Shape shape = text;
            
            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width); //100

            //Downcasting
            Shape shape = new Text();
            Text text = (Text) shape;
            text.FontName = "test";

        }
    }
}
