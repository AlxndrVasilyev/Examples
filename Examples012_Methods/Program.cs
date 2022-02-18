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
