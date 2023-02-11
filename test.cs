// Hello World! program
namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            System.Console.WriteLine("Testing Branching!");
        }

        //Basic loop in C#
        int test = 4;
        while(int i = 0; i < test; i++){
            System.Console.WriteLine(i);
        }
            
            System.Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
    }
}
