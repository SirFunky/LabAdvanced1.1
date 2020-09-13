using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLab1;
using ClassLibraryLab1._2;

namespace LabAdvanced1._1
{
    class Program
    {
        public delegate double KostnadsKalkyl(double MonthlySalary, string KnownProgramingLanguege, string hasMentee);
        static void Main(string[] args)
        {
            double totalMonthlySalary = 0;           
            Mentor sven = new Mentor ("Nej",1,1,30000,"Sven","C#","Nej",0);
            Mentor eva = new Mentor("Ja", 2, 2, 30000, "Eva", "C#", "ja",4);
            Mentor lena = new Mentor("Nej",3,3, 30000, "Lena", "Java", "ja",0);
            Mentor bengt = new Mentor("Ja", 4, 4, 30000, "bengt", "C#", "ja",2);

            SortedDictionary<string, Mentor> listaProgrammerare = new SortedDictionary<string, Mentor>(); //Valde sorted dictonary för dess funktion att både ha en key och ett objekt parat, mest för möjligheten till vidare utveckling senare då det kan vara bra att ha tillgång till keys för indexering osv.
            listaProgrammerare.Add("1", eva);
            listaProgrammerare.Add("2", sven);
            listaProgrammerare.Add("3", lena);
            listaProgrammerare.Add("4", bengt);
            

            foreach (KeyValuePair<string, Mentor> kv in listaProgrammerare)
            {
                string hasMentee = kv.Value.hasMentee;
                string KnownProgramingLanguege = kv.Value.KnownProgramingLanguege;
                double MonthlySalary = kv.Value.MonthlySalary;

                KostnadsKalkyl kal1 = new KostnadsKalkyl(company.Payincrease);                
                kv.Value.MonthlySalary = kal1(MonthlySalary, KnownProgramingLanguege, hasMentee);
                Console.WriteLine(kv.Key + " " + kv.Value);                

                totalMonthlySalary += kv.Value.MonthlySalary;
            }
            Console.WriteLine("total månads lön för programmerare" + totalMonthlySalary);
            

            bool test = true;
            while (test)
            {
                Console.WriteLine("Skapa programmerare (s)");
                Console.WriteLine("Lägg till mentee (u)");
                Console.WriteLine("Ändra programerings språk (d)");
                Console.WriteLine("Avsluta (e)");

                try
                {
                    string menu = Console.ReadLine();

                    switch (menu)
                    {
                        case "s":
                            Console.WriteLine(eva.EmployeName + " " + eva.MonthlySalary);
                            break;

                        case "u":
                            Console.WriteLine(sven);
                            break;

                        case "d":
                            break;

                        case "e":
                            test = false;
                            break;

                        default:
                            test = true;
                            break;
                    }                                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unknown error please restart and try again.");
                }
            }

        }
    }
}
