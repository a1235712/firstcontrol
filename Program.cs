//Задача : Напишите программу, которая из имеющегося массива
// строк формирует массив из строк, длина которых равна меньше или равна три символа
//Перевоначальный массив можно ввести с клавиатуры либо задать
// на старте выполнения алгоритма

string[] arr =

{
    "bello", "2", "world", ":-)",
    "Russia", "Denmark", "-2",  "1234", "1567",
    "computer  science",
};

string[] GetValidArray(string[] array)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }

    }
    Console.WriteLine();


    string[] ValidArray = new string[count];
    {

        int j = 0;

        for (int i = 0; i < size; i++)
        {
            if (array[i].Length <= 3)
            {
                ValidArray[j++] = array[i];
            }

        }
        return ValidArray;
    }
}
string PrintArray(string[] array)
{
    int size = array.Length;
    string print = String.Empty;
    for (int i = 0; i < size; i++)
    {
        print += $"{array[i]}  ";
    }

    return print;
}

Console.WriteLine();
Console.WriteLine(PrintArray(arr));
Console.WriteLine();
string[] valid = (GetValidArray(arr));

Console.WriteLine($"{PrintArray(valid)} ");
Console.WriteLine();
