// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равно 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] ControlTask(string[] firstArray)
{
    int CountElements(string [] array)
    {
        int result = 0;
        int length = array.Length;
        for (int i = 0; i < length; i++)
        {
            if (array[i].Length <= 3) result++;
        }
        return result;

    }
string[] resultArray = new string[CountElements(firstArray)];
    int count = firstArray.Length;
    int i = 0;
    int k = 0;
    while (i < count)
    {
        if (firstArray[i].Length <= 3)
        {
            resultArray[k] = firstArray[i];
            k = k + 1;
        }
        i = i + 1;
    }
    return resultArray;
}
string PrintArray(string[] array)
{
    int length = array.Length;
    string result = String.Empty;
    for (int i = 0; i < length; i++)
    {
        result = result + ($"array[{i + 1}]: {array[i]} \n");
    }
    return result;
}

string[] firstArray = { "один", "два", "три", "четыре", "пять" };
string[] resultArray = ControlTask(firstArray);
Console.WriteLine(PrintArray(resultArray)); 