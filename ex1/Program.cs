// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами. 
// Примеры: 
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"] 
// ["1234", "1567", "-2", "com.puter science"] -> ["-2"] 
// ["Russia", "Denmark", "Кazan"] -> []

void PrintArray(string[] array)
{
    Console.Write(" [ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("  ] ");
}

Console.Write("Введите количество значений:  ");
int m = Convert.ToInt32(Console.ReadLine());
if ( m < 1)
{
    Console.WriteLine("Введите другое число");
}
else
{
    string[] arrStr1 = new string[m];
    string[] arrStr2 = new string[m];
    for (var j = 0; j < m; j++)
    {
        arrStr1[j] = Console.ReadLine();
        string temp = arrStr1[j];  
            if ( temp.Length < 4)
            {
                arrStr2[j] = temp;
            }
    }
    PrintArray(arrStr1);
    Console.WriteLine(" ------------ ");
    PrintArray(arrStr2);
}