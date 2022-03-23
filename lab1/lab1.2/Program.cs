using System;

namespace lab1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student() { Age = 20, Id = 123, GroupNumber = 22, Name = "Пётр"};
            Student student2 = new Student() { Age = 22, Id = 345, GroupNumber = 42, Name = "Артём"};

            student1.Add(student2);
            student2.AddThree(student1, student2);

            Console.WriteLine("Student1:");
            Console.WriteLine($"Id = {student1.Id}, Age = {student1.Age}, Name = {student1.Name}, GroupNumber = {student1.GroupNumber}");
            Console.WriteLine("Student2:");
            Console.WriteLine($"Id = {student2.Id}, Age = {student2.Age}, Name = {student2.Name}, GroupNumber = {student2.GroupNumber}");
        }
    }
}
