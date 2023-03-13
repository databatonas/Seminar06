﻿//Задача 39. 
/*Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
  а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

try /* Блок обработки исключений.*/
{
    Console.WriteLine("Введите число количества элементов требуемого массива.");
    Console.WriteLine("Число должно быть целым и положительным.");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[number];/*Создаем массив и укажем, что в нем (number) элементов.*/

    if (number == 0) /* Если число количества элементов требуемого массива рано нулю, то...*/
    {
        Console.WriteLine("В массиве нет элементов"); /* выводим на экран "В массиве нет элементов".*/
        return; /* Возвращаемся на исходную точку.*/
    }

    FillArray(array);     /*Вызываем метод заполнения массива,который мы описали ниже, 
                            с наименованием созданного массива (array). */
    PrintArray(array);    /*Вызываем метод вывода на печать, который мы описали ниже, 
                            с наименованием созданного массива (array) */
    InvertedArray(array); /* Вызываем метод переворачивания массива, который мы описали ниже.*/
    Console.WriteLine();  /*Пустая сторока для того, чтобы сделать пробел между выводами на экране.*/
    PrintArray(array);    /*Вызываем метод вывода на печать (теперь будет печататься перевёрнутый массив).*/

    // Метод заполнения массива.
    void FillArray(int[] array, int from = 0, int to = 0) /*void-оператор, который ни чего не возвращает.
 FillArray (перевод-заполняющий массив)- наименование метода . array (перевод- массив)- аргумент
 (любое слово), from (перевод- от)- начало диапозона заполнения массива, to (перевод- до)- конец
 диапозона заполнения массива.*/
    {
        Console.WriteLine("Введите целое число начала диапозона требуемого массива.");
        from = Convert.ToInt32(Console.ReadLine()); /* Вывод на экран переменной from.*/
        Console.WriteLine("Введите целое число конца диапозона требуемого массива.");
        to = Convert.ToInt32(Console.ReadLine()); /* Вывод на экран переменной to.*/
        Console.WriteLine(); /* Пустая строка для отделения от ответа при чтении на экране.*/

        if (from > to) (from, to) = (to, from); /* Если число начала диапозона больше
    числа окончания диапозона, то поменяем их местами.*/

        for (int i = 0; i < array.Length; i++) /* Вводим переменную (i)- это позиция первого элемента массива.
    До тех пор, пока позиция элемента массива меньше длины массива, увеличиваем значение позиции 
    элемента на (1) при каждой итерации.  */
        {
            array[i] = new Random().Next(from, to + 1); /* Заполняем наш массив случайными числами
        от (from) до (to). Увеличиваем переменную конца диапозона случайных чисел на (1) так как, 
        Random().Next(from, to) не включает последнюю цифру в диапозон.*/
        }
    }

    // Метод печати массива на экран.
    void PrintArray(int[] array)  /* PrintArray-печать массива. */
    {
        for (int i = 0; i < array.Length; i++) /* Вводим переменную (i)- это позиция первого элемента массива.
    До тех пор, пока позиция элемента массива меньше длины массива, увеличиваем значение позиции элемента
    на (1) при каждой итерации. */
        {
            if (i == 0) Console.Write($"["); /* Если индекс элемента раве нулю, т.е. (первый элемент массива),
        то на экран, сначала, выводим левую квадратную скобку.*/

            Console.Write($"{array[i]} ");/*Выводим на экран, в одну строку, через пробел,все элементы массива.*/

            if (i < array.Length - 1) Console.Write($", "); /* Если индекс элемента меньше длины 
        массива минус один, т.е. (последнего элемента массива), то ставим запятую.*/

            if (i == array.Length - 1) Console.Write($"]"); /* Если индекс элемента равен длине 
        массива минус один, т.е. (последнему элементу массива), то ставим правую квадратную скобку.*/
        }
        Console.WriteLine(); /* Пустая строка для перехода на новую строку для вывода следующего ответа.*/
    }

    /* Метод переворачивания массива.*/
    void InvertedArray(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++) /* Вводим переменную (i)- 
    это позиция первого элемента массива. До тех пор, пока позиция элемента массива меньше половины
    длины массива, увеличиваем значение позиции элемента на (1) при каждой итерации.  */
        {
            int t = array[i]; /* Вводим временную переменную (t) и присвоим ей значение 
                                 текущего элемента массива.*/
            array[i] = array[array.Length - 1 - i]; /* Присвоим текущему элементу массива от начала, 
                                                       значение текущего элемента от конца.*/
            array[array.Length - 1 - i] = t;        /* Присвоим текущему элементу массива от конца, 
                                                       значение временной переменной (t).*/            
        }
        Console.WriteLine();
        Console.WriteLine("Перевёрнутый массив");
    }
}
catch /* Окончание блока обработки исключений.*/
{
    Console.WriteLine("Некорректный ввод данных.");
}