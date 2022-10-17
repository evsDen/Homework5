// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество
// void InputArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = new Random().Next(100, 1000);
// }


// int a (int[] array)
// {
//    int count = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] % 2 == 0)
//          count = count + 1; // summaP += array[i];
//    }

//    return count;
// }


// Console.Clear();
// int[] array = new int[7];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"Количество четных чисел в массиве равна: {a(array)}");


// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// void InputArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = new Random().Next(-9, 10);
// }


// int Summa(int[] array)
// {
//    int summaP = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (i % 2 == 1)
//          summaP = summaP + array[i]; // summaP += array[i];
//    }

//    return summaP;
// }


// Console.Clear();
// int[] array = new int[6];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"Сумма чисел на нечетных позициях равна: {Summa(array)}");


// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // Внутренние функции использовать нельзя(Max и Min)
// void InputArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = new Random().Next(-9, 10);
// }


// int Maxi(int[] array)
// {
//    int max = array[0];
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (max < array[i])
//       max = array[i];     
//    }
//    return max;

// }

// int Min(int[] array)
// {
//    int min = array[0];
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (min > array[i])
//       min = array[i];     
//    }
//    return min;

// }
// int Rus(int[] array)
// {
// int k = 0;
//    k = Maxi = Min;    // Не понимаю почему тут ругается
//    return k;

// }


// Console.Clear();
// int[] array = new int[6];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"Сумма чисел на нечетных позициях равна: {Rus(array)}");
