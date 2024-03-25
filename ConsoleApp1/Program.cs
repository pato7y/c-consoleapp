namespace CSharpDemo;

class Program
{
    static void Main(string[] args)
    {
        int age=0;
        string birthyear ="ceng"; // change to 2000 to avoid exeption
        try
        {
            int byear = Int32.Parse(birthyear);
            int byear2 = Convert.ToInt32(birthyear);
            Console.WriteLine(byear);
            Console.WriteLine(byear2);
        }
        catch (System.Exception)
        {
            Console.WriteLine("Format exception");
        }
        
        if (Int32.TryParse(birthyear, out int y))
            age = 2024 - y;
        else
            Console.WriteLine("Invalid format ");

        Console.WriteLine("age:{0} " , age);
        
        Person p = new Person();
        Random rnd = new Random();

        Person[] pArr = new Person[10];
        Console.WriteLine("Web Applications");
        Console.WriteLine(Person.Count);  // access static property
        try
        {
            for (int i = 0; i < pArr.Length; i++)
            {
            
                pArr[i] = new Person();
                pArr[i].Age= rnd.Next(99);
            }

             foreach (var item in pArr)
            {
                Console.WriteLine(item.Age);
            }

        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
            //throw;
        }
        Console.WriteLine("Program ended!");
        
    }
}
