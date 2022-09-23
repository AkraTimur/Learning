using System;
using System.Collections.Generic;

namespace DictionaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> favoriteFoods = new Dictionary<string, string>();
            favoriteFoods["Alex"] = "hot dogs";
            favoriteFoods["A'ja"] = "pizza";
            favoriteFoods["Jules"] = "falafel";
            favoriteFoods["Naima"] = "spaghetti";
            /*В словарь добавляются четыре пары «ключ / значение». В данном случае ключом является имя, 
            а значением — любимая еда этого человека.*/
            string name;
            while ((name = Console.ReadLine()) != "")
            {
                if (favoriteFoods.ContainsKey(name)) //Метод ContainsKey возвращает true, если словарь содержит значение с указанным ключом.
                    Console.WriteLine($"{name}'s favorite food is {favoriteFoods[name]}"); // получаем значение, связанное с ключом.
                else
                    Console.WriteLine($"I don't know {name}'s favorite food");
               
            }
            

        }
    }
}
