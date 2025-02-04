// Цикли

// while, do while, for

int a = 28;
int b = 144;

// while
while (a != 1)
{
    a /= 2;
    //Console.WriteLine(a);
}

// цикл не виконається
while (a > 1)
{
    a /= 2;
    Console.WriteLine("second loop");
    //Console.WriteLine(a);
}

// 1. Перевіряємо умову
// 2. Виконуємо тіло циклу - якщо умова true
// 3. Повертаємось до пункту 1 - якщо умова true
// 4. Вихід з циклу - якщо умова false

// do while

string input;
int result = 0;

do
{
    Console.WriteLine("Enter a number");
    input = Console.ReadLine();
}
while (!int.TryParse(input, out result));

Console.WriteLine($"You entered number {result}");

//1.Виконуємо тіло циклу
// 2. Перевіряємо умову
// 3. Повертаємось до пункту 1 - якщо умова true
// 4. Вихід з циклу - якщо умова false

// for

Console.WriteLine("Start for loop");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

// 1. Ініціалізація ітератору
// 2. Перевірка умови
// 3. Виконання тіла циклу - якщо умова true
// 4. Виконання дії після кожної ітерації

// нескінченний цикл

while (true)
{
    int j = 0;
    Console.WriteLine(j++);
}

for (int k = 0; k < 20; k++)
{
    Console.WriteLine(k + 1);
}

// способи виходу с нескінченного циклу
// 1. Ключове слово break
// 2. Ключове слово return
// 3. Ключове слово goto

for (int i  = 0; ; i++)
{
    if (i == 100)
    {
        //break;
        //return;
        //goto End;
    }
}

bool isExit = false;

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        if (j == 5 && i == 5)
        {
            isExit = true;
            break;
        }
    }

    if (isExit)
    {
        break;
    }
}

End:
    Console.WriteLine("End");

// continue

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        continue;
    }
    Console.WriteLine(i);
}