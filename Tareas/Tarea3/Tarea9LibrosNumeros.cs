using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //programa para listado de libors/autores

        var books = new List<dynamic>
        {
            new { Title = "The Hobbit", Author = "J.R.R" },
            new { Title = "Harry Potter and The Chamber of Secrets", Author = "J.K Rowling" },
            new { Title = "The Art of War", Author = "Sun Tzu" }
        };

        Console.WriteLine("Lista de Libros:");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
        }

        var numbers = new List<int>();

        //Programa de listado de numeros 

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);

        numbers.RemoveAt(2);

        numbers.Insert(1, 25);

        int searchNumber = 40;
        int index = numbers.IndexOf(searchNumber);

        Console.WriteLine("\nLista de Números:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        if (index != -1)
        {
            Console.WriteLine($"\nEl número {searchNumber} se encuentra en la posición {index}.");
        }
        else
        {
            Console.WriteLine($"\nEl número {searchNumber} no se encuentra en la lista.");
        }
    }
}
