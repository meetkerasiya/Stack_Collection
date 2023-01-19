using System.ComponentModel.DataAnnotations;

class MyClass
{
    public static int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    public static Stack<int> numStack = new Stack<int>(numbers);
    public static void Main(string[] args)
    {
        Display();
        
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