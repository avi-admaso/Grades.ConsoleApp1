using Grades.ConsoleApp1;
Console.WriteLine("-MENU-");
Console.WriteLine("1.add student");
int teacherChoice = int.Parse(Console.ReadLine());
List<string> TheStudentsToString = new List<string>();
            int sum = 0;
    int[] studentGrades = new int[3];



void AddStudents()
{
    Console.WriteLine("put your name");
    string theTeacherName = Console.ReadLine();
    Console.WriteLine("How many student you want save");
    int studentToSave = int.Parse(Console.ReadLine());

    for (int i = 0; i < studentToSave; i++)
    {
        Console.WriteLine($"put student name num {i + 1}");
        string theStudentName = Console.ReadLine();
        Console.WriteLine("put student id");
        int studentId = int.Parse(Console.ReadLine());
        for (int j = 0; j < studentGrades.Length; j++)
        {
            Console.WriteLine($"put { 3 - j} student grades");
            studentGrades[j] = int.Parse(Console.ReadLine());

        }
        
        Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////");
        ;

        List<Teacher> teachers = new List<Teacher>();
        teachers.Add(new Teacher(theTeacherName, theStudentName, studentId, studentGrades));

        for (int j = 0; j < teachers.Count; j++)
        {
            FileStream theStudents = new FileStream(@$"c:\test\{theTeacherName}.txt", FileMode.Append);
            using (StreamWriter writer = new StreamWriter(theStudents))
            {
                writer.WriteLine($"The Teacher : {teachers[j].teacherName} The Student name:{teachers[j].studentName} The Students Id:0{teachers[j].id} The Grades:{teachers[j].grades[0]} {teachers[j].grades[1]} {teachers[j].grades[2]},");
            }
        }
    }

}
void StudentSum()
{
    for (int j = 0; j < studentGrades.Length; j++)
    {
        sum = sum + studentGrades[j]/j;
        Console.WriteLine(sum);
    }
}
try
{
    void studentToString(string fileName)
    {
        FileStream newFile = new FileStream($@"C:\test\{fileName}\.txt", FileMode.Open);
        using (StreamReader readFrom = new StreamReader(newFile))
        {

            for (int i = 0; i < readFrom.Peek(); i++)
            {
                TheStudentsToString.Add(readFrom.ReadLine());
            }

            foreach (string line in TheStudentsToString)
            {
                Console.WriteLine(line);
            }
        }
    }
}
catch (ArgumentException)
{

    throw new ArgumentException("wrong argument");
}
catch (Exception)
{

    Console.WriteLine("wrong parameter");
}



void TheTeacherChoice()
{
    switch (teacherChoice)
    {
        case 1:
            AddStudents();
            StudentSum();
            break;
        case 2:
            break;
    }
    
}
TheTeacherChoice();




