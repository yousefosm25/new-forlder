namespace ConsoleApp1 
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome");
       Console.WriteLine("enter your name: ");
       string name = Console.ReadLine();
       Console.WriteLine("Hello " + name);
       Console.WriteLine("please enter your number1: ");
       int number1; 
       int.TryParse(  Console.ReadLine(), out number1 );
       Console.WriteLine("please enter your number2: ");
       int number2;
       int.TryParse(  Console.ReadLine(), out number2 );
       Console.WriteLine("for  + enter 1");
       Console.WriteLine("for  - enter 2");
       Console.WriteLine("for  * enter 3");
       Console.WriteLine("for  / enter 4");
       Console.WriteLine("for  % enter 5");
       Console.WriteLine("for  ^ enter 6");
       Console.WriteLine("for  & enter 7");
       Console.WriteLine("for  | enter 8");
       int i = 0;
       int.TryParse(Console.ReadLine(), out i);
       if (i ==1)
       {
         Console.WriteLine(number1 + number2);
       }
       else if (i ==2)
       {
         Console.WriteLine(number1 - number2);
       }
       else if (i ==3)
       {
         Console.WriteLine(number1 * number2);
       }
       else if (i ==4)
       {
         Console.WriteLine(number1 / number2);
       }
       else if (i ==5)
       {
         Console.WriteLine(number1 % number2);
       }
       else if (i ==6)
       {
         Console.WriteLine(number1 ^ number2);
       }
       else if (i ==7)
       {
         Console.WriteLine(number1 & number2);
       }
       else if (i ==8)
       {
         Console.WriteLine(number1 | number2);
       }
       Console.WriteLine("Thank you for using my application");
    }

  }
}