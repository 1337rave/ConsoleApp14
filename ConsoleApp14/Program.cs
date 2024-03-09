using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

// Інтерфейс ISort
interface ISort
{
    void SortAsc();
    void SortDesc();
    void SortByParam(bool isAsc);
}

// Клас MyArray з імплементованим інтерфейсом ISort
class MyArray : ISort
{
    private int[] arr;

    // Конструктор для ініціалізації масиву
    public MyArray(int[] array)
    {
        arr = array;
    }

    // Реалізація методу інтерфейсу ISort - сортування масиву за зростанням
    public void SortAsc()
    {
        Array.Sort(arr);
    }

    // Реалізація методу інтерфейсу ISort - сортування масиву за спаданням
    public void SortDesc()
    {
        Array.Sort(arr);
        Array.Reverse(arr);
    }

    // Реалізація методу інтерфейсу ISort - сортування масиву залежно від переданого параметра
    public void SortByParam(bool isAsc)
    {
        if (isAsc)
            SortAsc();
        else
            SortDesc();
    }

    // Метод для виведення масиву на екран
    public void PrintArray()
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 8, 1, 4 };

        // Створення об'єкту класу MyArray з ініціалізацією масиву
        MyArray array = new MyArray(numbers);

        Console.WriteLine("Original array:");
        array.PrintArray();

        // Сортування за зростанням
        Console.WriteLine("Sorted array in ascending order:");
        array.SortAsc();
        array.PrintArray();

        // Сортування за спаданням
        Console.WriteLine("Sorted array in descending order:");
        array.SortDesc();
        array.PrintArray();

        // Сортування залежно від переданого параметра
        Console.WriteLine("Sorted array based on parameter (true - ascending, false - descending):");
        array.SortByParam(true);
        array.PrintArray();

        array.SortByParam(false);
        array.PrintArray();
    }
}
