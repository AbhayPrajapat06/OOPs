// class Student
// {
//     public string Name="";
//     public int Age;
//     public string City="";
//     public void Introduce()
//     {
//         Console.WriteLine($"Hi, My Name is {Name} and my age {Age} and i am from {City}");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Student s1=new Student();
//         s1.Name="Abhay";
//         s1.Age=24;
//         s1.City="Panipat";
//         s1.Introduce();

//         Student s2= new Student();
//         s2.Name="Rahul";
//         s2.Age=67;
//         s2.City="Sonipat";
//         s2.Introduce();

//         Student s3=new Student();
//         s3.Name="Abhishek";
//         s3.Age=28;
//         s3.City="Hardoi";
//         s3.Introduce();
//     }
// }

//Q1. Car class banao: fields Brand (string), Color (string), Speed (int). Method ShowInfo() jo print kare: Brand: Honda, Color: Red, Speed: 80. Do car objects banao.
// class Car
// {
//     public string Brand="";
//     public string Color="";
//     public int Speed;
//     public void ShowInfo()
//     {
//         Console.WriteLine($"Brand: {Brand}, Color: {Color}, Speed: {Speed}.");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Car c1=new Car();
//         c1.Brand="Volvo";
//         c1.Color="Red";
//         c1.Speed=900;
//         c1.ShowInfo();

//         Car c2=new Car();
//         c2.Brand="Honda";
//         c2.Color="Green";
//         c2.Speed=100;
//         c2.ShowInfo();
//     }
// }

//Q2. Book class banao: Title, Author, Price. Method Display(). Teen books banao aur teeno display karo.
// class Book
// {
//     public string Title="";
//     public string Author="";
//     public int Price;
//     public void Display()
//     {
//         Console.WriteLine($"Book {Title}, {Author}, {Price}");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Book b1=new Book();
//         b1.Title="An Elephant";
//         b1.Author="Abhay";
//         b1.Price=20;
//         b1.Display();

//         Book b2=new Book();
//         b2.Title="A Donkey";
//         b2.Author="Abhishek";
//         b2.Price=90;
//         b2.Display();

//         Book b3 =new Book();
//         b3.Title="A Owl";
//         b3.Author="Neel Kamal";
//         b3.Price=89;
//         b3.Display();
//     }
// }

//Q3. Rectangle class banao: Length, Width. Methods Area() aur Perimeter() jo number return karein (print nahi). Main mein result print karo.
// class Rectangle
// {
//     public int Length;
//     public int Width;
//     public int Area()
//     {
//         return Length*Width;
//     }
//     public int Perimeter(){
//         return Length+Width;
//     }
// }
// class Programe
// {
//     static void Main()
//     {
//         Rectangle r1=new Rectangle();
//         r1.Length=90;
//         r1.Width=90;
//         Console.WriteLine($"Area is {r1.Area()}");
//         Console.WriteLine($"Perimeter is {r1.Perimeter()}");
//     }
// }

//Q4. Student class mein Marks (int) add karo. Method GetGrade() jo return kare:
// 90+ → "A"
// 75 se 89 → "B"
// 50 se 74 → "C"
// 50 se kam → "Fail"
// Paanch students ke grade print karo.
//Ans 4
// class Student
// {
//     public int Marks;
//     public void GetGrade()
//     {
//        if(Marks>=90)
//        {
//         Console.WriteLine("Grade A");
//        }
//        else if(Marks>=75 || Marks==89)
//        {
//         Console.WriteLine("Grade B");
//        }
//        else if(Marks>=50 || Marks==74)
//        {
//         Console.WriteLine("Grade C");
//        }
//        else if(Marks<50)
//        {
//         Console.WriteLine("Fail");
//        }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Student s1=new Student();
//         s1.Marks=50;
//         s1.GetGrade();
//     }
// }

//Q5. BankAccount class: AccountHolder, Balance. Methods Deposit(int amount) aur Withdraw(int amount). Agar balance se zyada nikalo to print karo "Insufficient balance" aur balance mat ghatao.
// class BankAccount
// {
//     public string AccountHolder="";
//     public int Balance;
//     public void Deposit(int amount)
//     {
//         Balance=amount;
//         Console.WriteLine($"Deposite {Balance} Rupees");
//     }
//     public void Withdraw(int amount)
//     {
//         if(Balance>=amount)
//         {
//             Console.WriteLine($"Remaining Balance is {Balance-amount}");
//         }
//         else{
//             Console.WriteLine("Insufficient Balance");
//         }
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         BankAccount b1=new BankAccount();
//         b1.Deposit(900);
//         b1.Withdraw(800);
//     }
// }