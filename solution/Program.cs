// Задача: 
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

string [] ArrWithLessThen3Symbols(string [] arr1, string [] arr2)
{
    int i = 0;
    for (int j = 0;  j < arr1.Length; j++)
        {
            if (arr1[j].Length <= 3)
            {
                arr2[i] = arr1[j]; 
                i++;
            }
        }     
    return arr2;
}


Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string [] arr= new string[size];
int count = 0;

for (int n = 0; n < size; n++)
{
    Console.Write($"Введите {(n + 1)} элемент массива: ");
    arr[n] = Console.ReadLine();
    if (arr[n].Length <= 3)
    {
        count++;
    }
}
Console.WriteLine($"Таких строк: {count}");
string [] resultArr = new string[count];
Console.WriteLine("Массив из строк, длина которых меньше или равна 3:");
resultArr = ArrWithLessThen3Symbols(arr, resultArr);
Console.WriteLine(string.Join(", ", resultArr));