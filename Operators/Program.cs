// Оператори в C#

// 1. Арифметичні оператори
// +, -, *, /, %
// 2. Оператори порівняння
// ==, !=, >, <, >=, <=
// 3. Логічні оператори
// &&, ||, !
// 4. Оператор присвоювання
// =, +=, -=, *=, /=, %=
// 5. Оператори збільшення/зменшення
// ++, --
// 6. Побітові оператори
// &, |, ^, ~, <<, >>

// 0 => 0
// 1 => 1
// 2 => 10
// 3 => 11
// 4 => 100
// 5 => 101
// 6 => 110
// 7 => 111
// 8 => 1000
// 9 => 1001
// 10 => 1010
// 11 => 1011
// 12 => 1100
// 13 => 1101
// 14 => 1110
// 15 => 1111
// 16 => 10000



int a = 15;
int b = 10;
int c = 10;

decimal a1 = 2;
decimal b1 = 8;

float numberResult;
bool boolResult;

// Арифметичні оператори
numberResult = a + b; // 25
numberResult = a - b; // 5
numberResult = a * b; // 150
numberResult = a / b; // 1
numberResult = a % b; // 5

decimal d1 = a1 % b1; // 2

//decimal c1 = a1 + b1;
//int k = 'c' + 28;

boolResult = a == b; // false
boolResult = a != b; // true
boolResult = a > b; // true
boolResult = a <= b; // false
boolResult = a >= c; // true

boolResult = (a == b) || (a > b + 10); // true
boolResult = (b + 5 == a) && (b < 20) && !(c < 5); // true

// Оператор присвоювання
c = c + 5; // 15
c += 5; // 20
c -= 5; // 15

// 0 / 0 = ? - помилка
// 0 * ? = 0 - невизначеність

// Оператори збільшення/зменшення
c++; // 16
c--; // 15

++c; // 16
--c; // 15

boolResult = a == c++; // true
c--;
boolResult = a == ++c; // false

c = 2 & 2; // 2
// 0010
// 0010
// 0010

c = 2 | 1; // 3
// 0010
// 0001
// 0011

c = c >> 1; // 1

// Оператори розгалудження

if (a != b)
{
    Console.WriteLine("a is not equal b");
}
else
{
    Console.WriteLine("a equal b");
}

if (a == b)
{
    Console.WriteLine("a equal b");
}
else if (a > b)
{
    Console.WriteLine("a is greater than b");
}
else
{ 
    Console.WriteLine("a is less than b");
}

if (c == 1)
{

}
else if (c == 2)
{ 

}
else if (c == 3)
{
}
else
{
}

switch (c)
{
    case 1:
        Console.WriteLine("c is 1");
        break;
    case 2:
        Console.WriteLine("c is 2");
        break;
    case 3:
        Console.WriteLine("c is 3");
        break;
    case 4:
    case 5:
        Console.WriteLine("c is 4 or 5");
        break;
    default:
        Console.WriteLine("c is not 1, 2, 4, 5 or 3");
        break;
}

//string str = "asd";

// Тернарний оператор

int age = 15;

string description;

if (age >= 18)
{
    description = "Adult";
}
else if (age < 12)
{
    description = "Child";
}
else
{
    description = "Teenager";
}

description = age >= 18 ? 
                "Adult" : (age < 12 ? "Child" : "Teenager");

description = age switch
{
    >= 18 => "Adult",
    < 12 => "Child",
    _ => "Teenager"
};