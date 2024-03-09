using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Інтерфейс IMath
interface IMath
{
    int Max();
    int Min();
    float Avg();
    bool Search(int valueToSearch);
}

// Клас Array з імплементованим інтерфейсом IMath
class Array : IMath
{
    private int[] arr;

    // Конструктор для ініціалізації масиву
    public Array(int[] array)
    {
        arr = array;
    }

    // Реалізація методу інтерфейсу IMath - повертає максимум серед елементів масиву
    public int Max()
    {
        return arr.Max();
    }

    // Реалізація методу інтерфейсу IMath - повертає мінімум серед елементів масиву
    public int Min()
    {
        return arr.Min();
    }

    // Реалізація методу інтерфейсу IMath - повертає середнє арифметичне серед елементів масиву
    public float Avg()
    {
        return (float)arr.Average();
    }

    // Реалізація методу інтерфейсу IMath - шукає значення всередині масиву
    public bool Search(int valueToSearch)
    {
        return arr.Contains(valueToSearch);
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Створення об'єкту класу Array з ініціалізацією масиву
        Array array = new Array(numbers);

        // Виклик методів для тестування функціональності
        Console.WriteLine($"Max: {array.Max()}");
        Console.WriteLine($"Min: {array.Min()}");
        Console.WriteLine($"Avg: {array.Avg()}");
        Console.WriteLine($"Search 3: {array.Search(3)}");
        Console.WriteLine($"Search 10: {array.Search(10)}");
    }
}
