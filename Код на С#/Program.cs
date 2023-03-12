// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
string[] GetArray = new string[5] { "1", "2", "3", "4", "5" };
int CountNumbers(string[] array)
{
   int count = 0;
   for (int i = 0; i < GetArray.Length; i++)
   {
      if (GetArray[i].Length < 4 && GetArray[i].Length > 2)
      {
         count++;
      }

   }
   return count;
}
Console.WriteLine(String.Join(",", GetArray));
int count = CountNumbers(GetArray);
Console.WriteLine(count);