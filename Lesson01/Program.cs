class Student
{
    public string Name="";
    public int Age;
    public string City="";
    public void Introduce()
    {
        Console.WriteLine($"Hi, My Name is {Name} and my age {Age} and i am from {City}");
    }

}

class Program
{
    static void Main()
    {
        Student s1=new Student();
        s1.Name="Abhay";
        s1.Age=24;
        s1.City="Panipat";
        s1.Introduce();

        Student s2= new Student();
        s2.Name="Rahul";
        s2.Age=67;
        s2.City="Sonipat";
        s2.Introduce();

        Student s3=new Student();
        s3.Name="Abhishek";
        s3.Age=28;
        s3.City="Hardoi";
        s3.Introduce();
    }

    
}