// See https://aka.ms/new-console-template for more information
class Myclass
{
    enum Grade { pass = 60, distinction = 85 };

    public static void Main()
    {
        int empid;
        int mark;

        Console.WriteLine("whats your empid?");
        empid = int.Parse(Console.ReadLine());
        Console.WriteLine("hello world");
        Console.WriteLine($"thanks for giving empid {empid}");
        Console.WriteLine("enter your tsql mark?");
        mark = int.Parse(Console.ReadLine());
        if (mark >= (int)Grade.distinction)
                {
                     Console.WriteLine("you are in distincation grade");
                }
        else if (mark >= (int)Grade.pass)
       
            { 
            Console.WriteLine("you are in pass grade"); 
            }
        else
                 {
                     Console.WriteLine("sorry, your grade is fail");
                 }
    }
}
