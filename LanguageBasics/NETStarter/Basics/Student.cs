using System;

class Student
{
    public static string studentType = "Tech";
    // private string name;
    public string Name { get; set; }
    // {
    //     get
    //     {
    //         return name;
    //     }

    //     set
    //     {
    //         name = value;
    //     }
    // }


    public string address;
    public int roll;
    public DateTime dob;

    public void PrintDetails()
    {
        Console.WriteLine($"{Name} {address} {roll} {dob}");
    }

    public static void PrintStudentType()
    {
        Console.WriteLine($"Student Type: {studentType}");
    }
}