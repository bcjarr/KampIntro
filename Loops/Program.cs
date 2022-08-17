


using Loops;

class Program : ICourseAbs
{
    public string InstructorName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string InstructorLastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int InstructorAge { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int InstructorNationalIdentity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public long InstructorPhoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string InstructorBirthPlace { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    static void Main(String[] args)
    {
        Courses coursessss = new Courses();
            
        coursessss.InstructorBirthPlace = "İzmir";
        coursessss.InstructorPhoneNumber = 012324607571;
        coursessss.InstructorNationalIdentity = 65123710;
        coursessss.InstructorName = "Can";
        Console.WriteLine(coursessss.InstructorName + " " + coursessss.InstructorNationalIdentity);
        Console.WriteLine(coursessss.InstructorBirthPlace + " " + coursessss.InstructorPhoneNumber);

        Console.WriteLine(Environment.NewLine);

        Courses courses1 = new Courses();

        courses1.InstructorBirthPlace = "Adıyaman";
        courses1.InstructorPhoneNumber = 9892307571;
        courses1.InstructorNationalIdentity = 412398710;
        courses1.InstructorName = "Mustafa";

        Console.WriteLine(courses1.InstructorName + " " + courses1.InstructorNationalIdentity);
        Console.WriteLine(courses1.InstructorBirthPlace + " " + courses1.InstructorPhoneNumber);

        Console.WriteLine(Environment.NewLine);


        Courses courses2 = new Courses();


        courses2.InstructorBirthPlace = "Adıyaman";
        courses2.InstructorPhoneNumber = 9892307571;
        courses2.InstructorNationalIdentity = 412398710;
        courses2.InstructorName = "Mustafa";
        Console.WriteLine(courses2.InstructorName + " " + courses2.InstructorNationalIdentity);
        Console.WriteLine(courses2.InstructorBirthPlace + " " + courses2.InstructorPhoneNumber);

        Console.WriteLine(Environment.NewLine);

        Courses courses3 = new Courses();

        courses3.InstructorBirthPlace = "Diyarbakır";
        courses3.InstructorPhoneNumber = 053520612371;
        courses3.InstructorNationalIdentity = 124398710;
        courses3.InstructorName = "Musa";

        Console.WriteLine(courses3.InstructorName + " " + courses3.InstructorNationalIdentity);
        Console.WriteLine(courses3.InstructorBirthPlace + " " + courses3.InstructorPhoneNumber);

        Console.WriteLine(Environment.NewLine);


        string[] kurslar = new string[] { "Yazılım geliştrime kursu", "Java", "Python", "C# KURSU" };

        for (int i = 0; i < kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }
        Console.WriteLine("For döngüsü bitti");
        Console.WriteLine(Environment.NewLine);

        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }
        Console.WriteLine("Kurslar ve foreach bitti");
    }
}
public class Courses
{
    public string InstructorName { get; set; }
    public string InstructorLastName { get; set; }

    public int InstructorAge { get; set; }
    public int InstructorNationalIdentity { get; set; }

    public long InstructorPhoneNumber { get; set; }
    public string InstructorBirthPlace { get; set; }

}
