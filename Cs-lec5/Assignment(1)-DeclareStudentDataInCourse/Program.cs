using System;

namespace StudentDataInTheCourse
{
    /*
        Write a program to declare student data in the
        course list; where each student declares by Id ,
        Name, degrees. The degrees consist of three
        marks (midterm exam, semester work, and final
        exam). Print all information for several students
        with the total degree for each student.
    */
    struct stDegree
    {
        public decimal midTerm;
        public decimal semesterWork;
        public decimal finalExam;
        public decimal totalDgrees;
    }
    struct stStudent
    {
        public string Name;
        public long Id;
        public stDegree Degree;
    }
    internal class Assignment1
    {
        static void ReadStudent(stStudent [] student)
        {
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"---------------Student({i})---------------");
                Console.Write("Please, enter the student name : ");
                student[i].Name = Console.ReadLine();
                Console.Write("Please, enter the student-Id  : ");
                student[i].Id = Convert.ToInt64(Console.ReadLine());
                Console.Write("Please, enter the mid term degree : ");
                student[i].Degree.midTerm = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Please, enter the semseter work degree : ");
                student[i].Degree.semesterWork = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Please, enter the final term degree : ");
                student[i].Degree.finalExam = Convert.ToDecimal(Console.ReadLine());
                student[i].Degree.totalDgrees = student[i].Degree.finalExam + 
                                            student[i].Degree.semesterWork +
                                          student[i].Degree.midTerm;
            }
        }
        static void PrintStudent(stStudent [] student)
        {
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"--------------{student[i].Name}--------------");
                Console.WriteLine($"Student-id : {student[i].Id}");
                Console.WriteLine($"Mid term degree : {student[i].Degree.midTerm}");
                Console.WriteLine($"Semseter work degree : {student[i].Degree.semesterWork}");
                Console.WriteLine($"Degree of final exam : {student[i].Degree.finalExam}");
                Console.WriteLine($"Total Degree : {student[i].Degree.totalDgrees}");
            }
        }
        static void Main()
        {
            Console.Write("Please, enter number of students : ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine()); 
            stStudent [] students = new stStudent [numberOfStudents];
            ReadStudent(students);
            PrintStudent(students);
        }
    }
}