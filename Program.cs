// Задача 1.
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или 
// при вводе числа, сумма цифр которого чётная.

while (true) //Истина == Истине
{ 
    Console.Write ("Введите текст: "); 
    string text = Console.ReadLine(); //Чтение строки ввода
    if(text == "q")//Проверка ввод'q'для выхода 
    { 
        break; 
    } 
       
    int number; //Проверка ввода, что текст состоит из цифр
    // 0, если в строке символы
    // либо введеное число
    if(int.TryParse(text, out number)) //Введенная строка конвертируется
    // в число (успешно, либо не успешно) текст попадает в number
    { 
        Console.WriteLine("Введенная строка состоит из цифр");
        int sum = 0;
        while (number>0) //Вычисление суммы цифр числа 
        { 
            sum += number % 10; //Добавление последней цифры к сумме 
            number /= 10; //Удаление последней цифры из числа
        }
        if (sum % 2 == 0)
        {
            break;
        } 
    }
    else //Ввод не является числом или 'q', повторить запрос 
    { 
          Console.WriteLine("Некорректный ввод. Пожалуйста,введите целое число или'q'.");
    }
}


// Задача 2.
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] result = CreateArray(N, 100, 1000);
// Console.WriteLine($"Массив: [ {string.Join("; ", result)} ] ");

// int count = 0;
// for(int i = 0; i < result.Length; i++)
// {
//     if(result[i] % 2 == 0)
//     {
//     count++;
//     }
// }
// Console.WriteLine(count);


// Задача 3. 
// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

// int [] CreateArray (int size)
// {
//     int [] array = new int[size];
//     for (int i=0; i<array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//     }
//     return array;
// }

// Console.Write("Ввести размер массив: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] result = CreateArray(N);
// Console.WriteLine($"Массив: [ {string.Join("; ", result)}] ");

// int [] reverse_array = new int[N];
// int j = result.Length - 1;
// foreach(int i in result)
// {
//     reverse_array[j] = i;
//     j--;
// }

// Console.WriteLine($"Массив: [ {string.Join("; ", reverse_array)}] ");
