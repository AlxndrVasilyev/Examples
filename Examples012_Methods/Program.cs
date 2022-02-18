// Виды методов (функций)

// Вариант 1

void Method1()
{
    Console.WriteLine("Некий текст, например");
}
// Вызывается метод так:

Method1();







// Вариант2. Ничего не возвращают, но принимают аргументы

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");
// Если функция принимает несколько аргументов, то:
// Method2(msg "Текст сообщения");
// например:
void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;

    }
} // для именнованных аргументов можно писать их по порядку, пример ниже
Method2_1(count: 3, msg: "Текст сообщения для метода 2_1");








// Вариант 3. Что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);








// Вариант 4. Что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Z!");
Console.WriteLine(res);





// Пример цикла с for

string MethodFor(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res1 = MethodFor(10, "for!");
Console.WriteLine(res1);




// Цикл можн использовать внутри цикла
// Таблица умножения, например

for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}




// ====== Работа с текстом.
// Нужно все пробелы заменить чёрточками
// маленькие буквы "к" заменить на большие "К"
// большие "В" заменить на маленькие "в"

// символы в строке можно отсчитывать начиная с нуля. Например:
// string s = "qwerty"
//             012345
// допустим s[3] это символ r

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "Вы бы взяли приступом согласие пруссокго короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'В', 'в');
Console.WriteLine(newText);





// Метод упорядочивания данных внутри массива
// Алгоритм сортировки методом выбора (минмакса/максимального/минимального)

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// метод печати массива
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

// метод упорядочивания массива
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);