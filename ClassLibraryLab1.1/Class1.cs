using System;

namespace ClassLibraryLab1._1
{
    class Company
    {
        private int totalMonthlySalary;
    }
    class Programmer : Company
    {
        public int PayRollNumber { get; set; }
        public double MonthlySalary { get; set; }
        public string EmployeName { get; set; }
        public string KnownProgramingLanguege { get; set; }
        public Programmer(int PayRollNumber, double MonthlySalary, string EmployeName, string KnownProgramingLanguege, string Mentor)
        {
            this.PayRollNumber = PayRollNumber;
            this.MonthlySalary = MonthlySalary;
            this.EmployeName = EmployeName;

        }
        public double Payincrease(double MonthlySalary, string KnownProgramingLanguege, string hasMentee)
        {
            if (KnownProgramingLanguege == "c#" && hasMentee == "Yes")
            {
                double löneBonus = 1.15;
                return MonthlySalary + löneBonus;
            }
            else if (KnownProgramingLanguege == "c#")
            {
                double löneBonus = 1.1;
                return MonthlySalary + löneBonus;
            }
            else if (hasMentee == "Yes")
            {
                double löneBonus = 1.05;
                return MonthlySalary + löneBonus;
            }
            else
            {
                return MonthlySalary;
            }
        }
        class Mentee
        {
            public int hasMentor { get; set; }
            public int menteeNumber { get; set; }
        }
        class Mentor
        {
            private string hasMentee;
            private int mentorNumber;
        }
    }
}
