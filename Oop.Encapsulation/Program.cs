using System;

namespace Oop.Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            subject subject = new subject();

            try
            {
                subject.Name = "Math";
                subject.Code = "ABC-123";
                subject.Teacher = "John Cena";
                subject.EctsPoints = 5;
                subject.StartDate = new DateOnly(2021, 6, 10);
                subject.EndDate = new DateOnly(2021, 12, 31);
                subject.ExamDate = new DateOnly(2021, 12, 31);

                Console.WriteLine($"Subject: {subject.Name}");
                Console.WriteLine($"Code: {subject.Code}");
                Console.WriteLine($"Teacher: {subject.Teacher}");
                Console.WriteLine($"ECTS Points: {subject.EctsPoints}");
                Console.WriteLine($"Start Date: {subject.StartDate}");
                Console.WriteLine($"End Date: {subject.EndDate}");
                Console.WriteLine($"Exam Date: {subject.ExamDate}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
