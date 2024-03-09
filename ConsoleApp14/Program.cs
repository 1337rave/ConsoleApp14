using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

// Інтерфейс IOutput
interface IOutput
{
    void Show();
    void Show(string info);
}

// Клас Array з імплементованим інтерфейсом IOutput
class Array : IOutput
{
    private int[] arr;

    // Конструктор для ініціалізації масиву
    public Array(int[] array)
    {
        arr = array;
    }

    // Реалізація методу інтерфейсу IOutput - відображає елементи масиву
    public void Show()
    {
        Console.WriteLine("Array elements:");
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }

    // Реалізація методу інтерфейсу IOutput - відображає елементи масиву та інформаційне повідомлення
    public void Show(string info)
    {
        Console.WriteLine($"Array elements: {info}");
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
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
        array.Show();
        array.Show("with additional info");
    }
}
