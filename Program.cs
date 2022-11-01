namespace Practice_test;
class Program
{
    static void Main(string[] args)
    {   
        int x = 0;
        int stuCount = 1;
        int teachCount = 2;
        int result = 0;
        result = stuCount + teachCount;

        Console.WriteLine("Hello, World!");
        Console.WriteLine(stuCount);
        Console.WriteLine(teachCount);
        Console.WriteLine(result);

        for (int i = 0; i < 10; i+=2) {
         Console.WriteLine(i);
     }
        Console.WriteLine("Pick a number between 1-100");
        x = Convert.ToInt32(Console.ReadLine());
        
        if (x > 0 && x < 51) {
            Console.WriteLine('A');
    }
       if (x > 50 && x < 101) {
        Console.WriteLine('B');
       }

       else 
       {
         Console.WriteLine('C');
       }

    }
}
