namespace LinqApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfObjects = new List<PrintWhenGetting>();
            for (int i = 1; i < 5; i++)
                listOfObjects.Add(new PrintWhenGetting() { InstanceNumber = i });
            

                Console.WriteLine("Set up the query");
                var result = 
                    from o in listOfObjects
                    select o.InstanceNumber;

            var immediate = result.ToList(); //Чтобы запрос был выполнен немедленно,
                                             //можно вызвать метод LINQ, который должен
                                             //перебрать весь список, — например,
                                             //метод ToList, который преобразует его в List<T>.
            Console.WriteLine("Run the foreach");
                foreach (var number in immediate)
                {
                    Console.WriteLine($"Writing #{number}");
                }
            }
        }
    }
