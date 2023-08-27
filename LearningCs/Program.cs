using System;

namespace LearningCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String interpolation, man använder strings som placeholders i meddelanden.
            // Exempel:
            Console.WriteLine("String interpolation:");
            String firstName = "Linus";
            Console.WriteLine($"Hejsan {firstName}!");
            Console.WriteLine("");

            // Konstanter går att sätta genom att använda termen "const", går aldrig att ändra.
            // Exempel:
            const double pi = 3.14;
            Console.WriteLine($"Pi är alltid = {pi}");
            Console.WriteLine("");

            // Type casting, låter en konvertera datatyper. Till exempel input i form av en string -> integer. 
            // Exempel:
            Console.WriteLine("Type casting:");
            int nummer = 20;
            String mobil = Convert.ToString(nummer);
            Console.WriteLine(mobil);
            Console.WriteLine(mobil.GetType());
            Console.WriteLine("");

            // String metoder, låter dig addera saker till en string.
            // Exempel:
            Console.WriteLine("String metoder:");
            String name = "Lajjan";
            String userName = name.Insert(0, "@");
            Console.WriteLine(userName);
            Console.WriteLine("");

            // Switches, smidigare/sparar fler rader än att använda flertalet if else if statements
            // Exempel:
            Console.WriteLine("Switches:");
            String dag = "Måndag";
            switch (dag)
            {
                case "Måndag":
                    Console.WriteLine("Idag är det måndag!");
                    break;
                case "Tisdag":
                    Console.WriteLine("Idag är det tisdag!");
                    break;
                //osv..
            }
            Console.WriteLine("");

            // Logical operators, kan vara väldigt smidiga när du vill att ett statement ska uppfylla två eller flera krav
            // eller något av kraven ska uppfyllas.
            // && = och
            // || = eller
            // Exempel:
            Console.WriteLine("Logical operators:");
            double temperatur = 28;
            if (temperatur >= 25 && temperatur <= 35)
            {
                Console.WriteLine("Idag är det lagom!");
            }
            temperatur = 50;
            if (temperatur >= 50 || temperatur <= -50)
            {
                Console.WriteLine("Gå inte utomhus!");
            }
            Console.WriteLine("");



        }
    }
}