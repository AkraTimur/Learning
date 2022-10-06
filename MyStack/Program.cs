using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создание стека с добавлением четырех строк
        Stack<string> myStack = new Stack<string>();
        myStack.Push("firts in line");
        myStack.Push("second in line");
        myStack.Push("third in line");
        myStack.Push("last in line");

        // Peek со стеком работает так же, как с очередью
        Console.WriteLine($"Peek() returned:\n{myStack.Peek()}");

        // Pop извлекает следующий элемент от КОНЦА стека
        Console.WriteLine($"The first Pop() returned:\n{myStack.Pop()}");
        Console.WriteLine($"The second Pop() returned:\n{myStack.Pop()}");

        Console.WriteLine($"Count before Clear():\n{myStack.Count}");
        myStack.Clear();
        Console.WriteLine($"Count after Clear():\n{myStack.Count}");


    }
}