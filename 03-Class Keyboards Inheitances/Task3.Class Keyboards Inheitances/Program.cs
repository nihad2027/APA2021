using Task3.Class_Keyboards_Inheitances;
class Program
{
    static void Main(string[] args)

    {
        Student student1 = new Student() { FirstName = "Resid", LastName = "Babazade ", Age = 23, Email = "resid@gmail.com", Id = 1, StudentNumber = "456783", Faculty = "IT", GPA = 98.5, Year = 2021 };
        Student student2 = new Student() { FirstName = "Ferid", LastName = "Veliyev ", Age = 23, Email = "ferid@gmail.com", Id = 2, StudentNumber = "458983", Faculty = "IT", GPA = 67.5, Year = 2020 };
        Student student3 = new Student() { FirstName = "Dadas", LastName = "Agazade ", Age = 23, Email = "dadas@gmail.com", Id = 3, StudentNumber = "452383", Faculty = "IT", GPA = 88.5, Year = 2022 };

        Teacher teacher1 = new Teacher("IT", "PAM", 1000, 15, "Seid", "Nuraliyev", 34, "seidsn@gmail.com", 4);
        Teacher teacher2 = new Teacher("IT", "PAM", 1000, 8, "Yagmur", "Novruzov", 22, "novruzof@gmail.com", 5);

        Administrator admin = new Administrator("Samir", "Abbasov", 45, " abbasov@gmail.com", 6, "dekan", "Masinqayirma", 5);

        student1.ShowStudentInfo();
        Console.WriteLine(student1.CalculateScholarship());

        student2.ShowStudentInfo();
        Console.WriteLine(student2.CalculateScholarship());

        student3.ShowStudentInfo();
        Console.WriteLine(student3.CalculateScholarship());

        teacher1.ShowTeacherInfo();
        Console.WriteLine(teacher1.CalculateSalary());


        teacher2.ShowTeacherInfo();
        Console.WriteLine(teacher2.CalculateSalary());

        admin.ShowAdminInfo();
        admin.GrantAccess(student1);
    }
}


