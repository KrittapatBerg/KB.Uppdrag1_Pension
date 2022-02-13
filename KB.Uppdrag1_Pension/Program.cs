using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Uppdrag1_Pension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vad heter du? Namn: ");
            string name = Console.ReadLine();

            Console.Write("Efternamn: ");
            string lastname = Console.ReadLine();

            Console.Write("Hur gammal är du? Svar: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int retireage = 65;
            int pension = retireage - age;
            
            Console.Clear();
            Console.WriteLine("Hej " + name + " " + lastname + "!" + " Du är " + age + " år gammal.");
            
            if (age >= retireage)
            {
                Console.WriteLine("Du är pensionär.");
            } 
            else 
            {
                Console.WriteLine("Nu har du " + pension + " år kvar till du går i pension.");
            }
            Console.ReadLine(); 
        }
    }
}
