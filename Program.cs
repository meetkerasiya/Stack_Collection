using System.ComponentModel.DataAnnotations;

class MyClass
{
    public static int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    public static Stack<int> numStack = new Stack<int>(numbers);
    public static void Main(string[] args)
    {
        Display();
        StackFeatures();
    }

    private static void StackFeatures()
    {
        while (true)
        {
            Console.WriteLine("Please enter choise from following. ");
            Console.WriteLine("1 To push a number into a stack");
            Console.WriteLine("2 To pop a number from a stack");
            Console.WriteLine("3 To check if perticular number is in stack");
            Console.WriteLine("4 To clear the stack");
            Console.WriteLine("5 To quit");

            int choise = -1;
            try
            {
                choise = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Please enter a number to push");
                    string input = Console.ReadLine();
                    int num = Int32.MaxValue;
                    try
                    {
                        num = int.Parse(input);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    numStack.Push(num);
                    Display();
                    break;
                case 2:
                    num = numStack.Pop();
                    Console.WriteLine(num + " Popped.");
                    Display();
                    break;
                case 3:
                    Console.WriteLine("Please enter a number to check if it's in stack");
                    input = Console.ReadLine();
                    num = Int32.MaxValue;
                    try
                    {
                        num = int.Parse(input);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    if (numStack.Contains(num))
                    {
                        Console.WriteLine("Yes " + num + " is in stack");
                    }
                    else
                    {
                        Console.WriteLine("No " + num + " is not in stack");
                    }
                    Display();
                    break;
                case 4:
                    numStack.Clear();
                    Display();
                    break;
                default:
                    Console.WriteLine("Exiting");
                    Environment.Exit(0);
                    break;
            }
        }
    }

    public static void Display()
    {
        Console.WriteLine("Members in slack are: ");
        foreach (int i in numStack)
        {
            Console.Write(i+", ");
        }
        Console.WriteLine("Total number of elements are "+numStack.Count);
        if(numStack.Count > 0)
        {
            Console.WriteLine("Top of the stack is " + numStack.Peek());
        }
        

    }
}