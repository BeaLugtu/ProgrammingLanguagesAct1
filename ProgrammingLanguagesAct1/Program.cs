using System;

namespace ProgrammingLanguagesAct1
{

    class Programh
    {
        static void Main(string[] args)
        {
            bool endProgram = false;
            StudentRecords student1 = new StudentRecords("2022023", 70, 65, 80); 
            StudentRecords student2 = new StudentRecords("2022184", 80, 85, 90);  
            StudentRecords student3 = new StudentRecords("2022201", 76, 75, 78);  

            while (!endProgram)
            {
                Console.Write("Enter student ID: ");
                string searchID = Console.ReadLine();

                StudentRecords student = null;
                if (student1.StudentID == searchID)
                    student = student1;
                else if (student2.StudentID == searchID)
                    student = student2;
                else if (student3.StudentID == searchID)
                    student = student3;

                if (student != null)
                {
                    Console.WriteLine($"Prelim Grade: {student.PrelimGrade}");
                    Console.WriteLine($"Midterm Grade: {student.MidtermGrade}");
                    Console.WriteLine($"Final Term Grade: {student.FinalTermGrade}");
                    Console.WriteLine($"Final Grade: {student.GetResult()}");
                }
                else
                {
                    Console.WriteLine("User not found.");
                }

                Console.WriteLine();
                Console.Write("Do you want to search again? (y/n): ");
                char input = Console.ReadLine().ToLower()[0];
                if (input != 'y')
                    endProgram = true;
            
                else
                {
                    Console.Clear();
                }

        }
            Console.WriteLine();
            Console.WriteLine("[Enter any key to Terminate...]");
            Console.ReadKey();
        }
    }

    class StudentRecords
    {
        public string StudentID { get; set; }
        public double PrelimGrade { get; set; }
        public double MidtermGrade { get; set; }
        public double FinalTermGrade { get; set; }
        public double FinalGrade { get; set; }

        public StudentRecords(string studentID, double prelimGrade, double midtermGrade, double finalTermGrade)
        {
            StudentID = studentID;
            PrelimGrade = prelimGrade;
            MidtermGrade = midtermGrade;
            FinalTermGrade = finalTermGrade;
        }

        public double CalculateAverage()
        {
            return (PrelimGrade + MidtermGrade + FinalTermGrade) / 3.0;
        }

        public string GetResult()
        {
            FinalGrade = CalculateAverage();
            return (FinalGrade >= 75) ? "PASSED" : "FAILED";
        }

    }
        
}