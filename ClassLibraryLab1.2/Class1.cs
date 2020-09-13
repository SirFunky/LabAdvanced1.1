using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab1._2
{
    public interface Employee
    {
        string ToString();
    }
    public abstract class Programmer : Employee
    {
        public int PayRollNumber { get; set; }
        public double MonthlySalary { get; set; }
        public string EmployeName { get; set; }
        public string KnownProgramingLanguege { get; set; }
        public string HasMentor { get; set; }
        public int MenteeNumber { get; set; }

        public Programmer(int PayRollNumber, double MonthlySalary, string EmployeName, string KnownProgramingLanguege, string HasMentor, int MenteeNumber)
        {
            this.PayRollNumber = PayRollNumber;
            this.MonthlySalary = MonthlySalary;
            this.EmployeName = EmployeName;
            this.KnownProgramingLanguege = KnownProgramingLanguege;
            this.HasMentor = HasMentor;
            this.MenteeNumber = MenteeNumber;

        }
        
        public override String ToString()
        {
            return " Payroll Number: " + PayRollNumber + " Monyhly Salary: " + MonthlySalary + " Employe Name: " + EmployeName + " Known Programing Languaege: " + KnownProgramingLanguege + " Has Mentor: " + HasMentor + " Mentee Number: " +  MenteeNumber;
        }
    }
    public class Mentor : Programmer , IComparable<Mentor>
    {
        public string hasMentee { get; set; }
        public int mentorNumber { get; set; }
        public string isMentor { get; set; }

        public Mentor (string hasMentee, int mentorNumber, int PayRollNumber, double MonthlySalary, string EmployeName, string KnownProgramingLanguege, string HasMentor, int MenteeNumber) : base( PayRollNumber, MonthlySalary, EmployeName, KnownProgramingLanguege, HasMentor, mentorNumber)
        {

            this.mentorNumber = mentorNumber;
            this.hasMentee = hasMentee;

        }
        public override string ToString()
        {
            return base.ToString() + " Has mentee: " +hasMentee + " Mentor number: " + mentorNumber;
        }

        public int CompareTo(Mentor other)
        {
            return this.EmployeName.CompareTo(other.EmployeName);
        }
    }

    public static class company
    {
        public static double Payincrease(double MonthlySalary, string KnownProgramingLanguege, string hasMentee)
        {
            if (KnownProgramingLanguege == "C#" && hasMentee == "Ja")
            {
                double löneBonus = 1.15;
                return MonthlySalary * löneBonus;
            }
            else if (KnownProgramingLanguege == "C#")
            {
                double löneBonus = 1.1;
                return MonthlySalary * löneBonus;
            }
            else if (hasMentee == "Ja")
            {
                double löneBonus = 1.05;
                return MonthlySalary * löneBonus;
            }
            else
            {
                return MonthlySalary;
            }
        }
    }
    public class UnknownInput : Exception
    {
        public UnknownInput()
        {
            Console.WriteLine("Unknown error please restart and try again.");
        }

        public UnknownInput(string message)
            : base(message)
        {
            Console.WriteLine("Unknown error please restart and try again.");
        }

        public UnknownInput(string message, Exception inner)
            : base(message, inner)
        {
            Console.WriteLine("Unknown error please restart and try again.");
        }
    }
}
