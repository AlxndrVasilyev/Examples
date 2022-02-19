// 

bool x = true;
bool y = false;

if(x)
    Console.WriteLine("x");  // выполниется если условие true
else
    Console.WriteLine("не x");  // выполнится если предыдущие условия не сработали(если false)


if(!x)  // отрицание
    Console.WriteLine("!x");
else
    Console.WriteLine("не !x");


if(x && y)  // логическое И
    Console.WriteLine("x && y");
else
    Console.WriteLine("не x && y");


if(x || y)  //логическое ИЛИ
    Console.WriteLine("x || y");
else
    Console.WriteLine("не x || y");