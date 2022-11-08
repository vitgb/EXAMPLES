// Виды методов
// Вид 1 - ничего не возвращаюи и не принимают
// void Mehod1()
// {
//     Console.WriteLine("Автор.......");
// }
// Mehod1();




// Вид 2 - что-то принимают и нечего не возвращают
// void Mehod2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Mehod2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// //Method21("Текст", 4);
// // или явно указываем (именованные аргументы необязательно писать по порядку)
// Method21(msg: "Текст", count: 4);

//ВИД 3
// ничего не принимают и что-то возвращают

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


//ВИД 4
// что-то принимают и что-то возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text; 
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);


//ЦИКЛ <for>

// string Method4(int count, string text)
// {
//         string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     { 
//         result = result + text; 
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);


// ДЕмонстрация использования цикла в цикле (вывод табл умножения)
/*
for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
*/
// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", большие "С" заменить маленькими "с".
/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             0123
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
*/

// ЗАДАЧА: УПОРЯДОЧИТЬ МАССИВ
// АЛГОРИТМ СОРТИРОВКИ МЕТОДА ВЫБОРА (МЕТДА МИН И МАКСА)

int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();   
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length - 1; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    } 
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
