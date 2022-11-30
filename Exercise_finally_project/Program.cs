/*  Задача: Написать программу,который из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
Примеры
["hello", "2", "world", ":-)"] -> ["2', ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
[Russia, Denmark, Kazan] -> []                     */

string[] array = new string[6];                                  

Console.WriteLine($"Введите 6 символов массива array: ");
for(int i=0; i<array.Length; i++)
{array[i] = Console.ReadLine()!;}

int length = new Random().Next(0,4);                    //Сгенерируем длина нового массива [0,3]диапазоне.
string[] arraynew = new string[length];
Console.WriteLine($"    length= {length}");

string[] NewArray(string[] arr)                         //Создаем Метод,который в зависимости от длины 
{                                                       //нового массива, сформирует новый массив,заполняя
Console.Write($"->  arraynew: [");                              //некоторими элементамы старого массива.
for(int i=0; i<length; i++)
{if(length == 3) arraynew[i] = arr[i+2];
 else if(length == 2) arraynew[i] = arr[i+3];
      else arraynew[i] = array[i+4];
if(i == length-1) Console.Write($"{arraynew[i]}");
else Console.Write($"{arraynew[i]}, "); }
Console.Write("]");
return arraynew;
}

