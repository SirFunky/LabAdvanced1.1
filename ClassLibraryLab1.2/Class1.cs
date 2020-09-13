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
    public class Programmer : Employee
    {
        public int PayRollNumber { get; set; }
        public double MonthlySalary { get; set; }
        public string EmployeName { get; set; }
        public string KnownProgramingLanguege { get; set; }
        public string HasMentor { get; set; }
        
        public Programmer(int PayRollNumber, double MonthlySalary, string EmployeName, string KnownProgramingLanguege, string HasMentor)
        {
            this.PayRollNumber = PayRollNumber;
            this.MonthlySalary = MonthlySalary;
            this.EmployeName = EmployeName;
            this.KnownProgramingLanguege = KnownProgramingLanguege;
            this.HasMentor = HasMentor;

        }
        
        public override String ToString()
        {
            return PayRollNumber + " " + MonthlySalary + " " + EmployeName + " " + KnownProgramingLanguege;
        }
    }
    class mentor : Programmer
    {
        public string hasMentee { get; set; }
        public int mentorNumber { get; set; }
        public string isMentor { get; set; }

        public mentor (string hasMentee, int mentorNumber, string isMentor, int PayRollNumber, double MonthlySalary, string EmployeName, string KnownProgramingLanguege, string HasMentor) : base( PayRollNumber, MonthlySalary, EmployeName, KnownProgramingLanguege, HasMentor)
        {
            this.isMentor = isMentor;
            this.mentorNumber = mentorNumber;
            this.hasMentee = hasMentee;

        }
        public override string ToString()
        {
            return base.ToString() + " " +hasMentee + " " + mentorNumber + " " + isMentor;
        }

    }

    static class company
    {
        public static double Payincrease(double MonthlySalary, string KnownProgramingLanguege, string hasMentee)
        {
            if (KnownProgramingLanguege == "c#" && hasMentee == "Yes")
            {
                double löneBonus = 1.15;
                return MonthlySalary * löneBonus;
            }
            else if (KnownProgramingLanguege == "c#")
            {
                double löneBonus = 1.1;
                return MonthlySalary * löneBonus;
            }
            else if (hasMentee == "Yes")
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
}
