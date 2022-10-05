

internal class Program
{
    private static void Main(string[] args)
    {
        // Создание очереди с добавлением четырех элементов
        Queue<string> myQueue = new Queue<string>();
        myQueue.Enqueue("first in line");
        myQueue.Enqueue("second in line");
        myQueue.Enqueue("third in line");
        myQueue.Enqueue("last in line");

        // Метод Peek "подсматривает" первый элемент очереди и возвращает его без удаления
        Console.WriteLine($"Peek() returned:\n{myQueue.Peek()}");

        // Метод Dequeue извлекает следующий элемент от НАЧАЛА очереди
        Console.WriteLine($"The first Dequeue() returned:\n{myQueue.Dequeue()}");
        Console.WriteLine($"The second Dequeue() returned:\n{myQueue.Dequeue()}");

        // Clear удаляет все элементы из очереди
        Console.WriteLine($"Count before Clear():\n{myQueue.Count}");
        myQueue.Clear();
        Console.WriteLine($"Count after Clear():\n{myQueue.Count}");
    }
}