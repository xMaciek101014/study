using System;

namespace Cwiczenie8Zadanie4
{
    public enum Gender
    {
        Male,
        Female
    }
    public struct Student
    {
        public string surname;
        public int studentNumber;
        public double grade;
        public Gender gender;
    }
    public class Program
    {
        public static void FillStudent(ref Student student, string surname, int studentNumber, double grade, Gender gender)
        {
            student.surname = surname;
            student.studentNumber = studentNumber;
            student.grade = Math.Max(2.0, Math.Min(5.0, grade));
            student.gender = gender;
        }
        public static void DisplayStudent(Student student)
        {
            string genderStr = student.gender == Gender.Male ? "Mężczyzna" : "Kobieta";
            Console.WriteLine($"Nazwisko: {student.surname}, Numer albumu: {student.studentNumber}, Ocena: {student.grade}, Płeć: {genderStr}");
        }
        public static double CalculateAverage(Student[] studentGroup)
        {
            double sumOfGrades = 0;
            foreach (var student in studentGroup)
            {
                sumOfGrades += student.grade;
            }
            return sumOfGrades / studentGroup.Length;
        }
        public static void Main(string[] args)
        {
            Student[] studentGroup = new Student[5];
            FillStudent(ref studentGroup[0], "Proskień", 146400, 5, Gender.Male);
            FillStudent(ref studentGroup[1], "Adamek", 168497, 4, Gender.Male);
            FillStudent(ref studentGroup[2], "Kowalska", 256874, 3, Gender.Female);
            FillStudent(ref studentGroup[3], "Markiewicz", 192587, 4, Gender.Female);
            FillStudent(ref studentGroup[4], "Nowak", 125896, 4, Gender.Male);
            foreach (var student in studentGroup)
            {
                DisplayStudent(student);
            }
            double average = CalculateAverage(studentGroup);
            Console.WriteLine($"Średnia ocena: {average}");
            Console.ReadLine();
        }
    }
}
