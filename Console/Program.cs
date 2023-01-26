int symbol = 3;                           
PrintData("Введите массив: ");
string str = ReadData();
string[] array = NewArray(str.Split(' '));
PrintData("Mассив длина строк которого меньше либо равнa 3 символа: ");
PrintArray(array);

//Метод ввода данных 
string ReadData()
{
    return Console.ReadLine()??"0";
}

//Метод вывода данных на печать
void PrintData(string res)
{
    Console.WriteLine(res);
}

//Метод печати массива
void PrintArray(string[]arr)
{
    Console.Write("[");
    if (arr.Any())
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.Write(arr[arr.Length - 1]);
    }
    Console.WriteLine("]");
}

//Метод добавления строки в массив
string[] AddToArray(string[]arr, string item)
{
    if (arr.Length == 0)
    {
        return new string[] { item };
    }
    string[] arrResult = new string[arr.Length + 1];
    arr.CopyTo(arrResult, 0);
    arrResult[arr.Length] = item;
    return arrResult;
}

//Метод формирования массива, длина строк которого меньше либо равнa 3 символа
string[] NewArray(string[]arr)
{
    string[]arrNew = new string[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (string.IsNullOrEmpty(arr[i]))
        continue;
        if (arr[i].Length - 1 < symbol) arrNew = AddToArray(arrNew, arr[i]);
    }
    return arrNew;
}