// ініціалізація та присвоєння змінної типу bool
bool myBooleanVariable;
myBooleanVariable = true; // присвоєння
myBooleanVariable = false;

/* 
 Це
 коментар
 на
 багато
 строк
 */

// цілі числа
// byte, short, int, long

// byte = 0 - 255, sbyte = -128 - 127
// short = -32,768 - 32,767, ushort = 0 - 65,535
// int = -2,147,483,648 - 2,147,483,647, uint = 0 - 4,294,967,295
// long = -9,223,372,036,854,775,808 - 9,223,372,036,854,775,807, ulong = 0 - 18,446,744,073,709,551,615

byte myByte = 255;
uint myUint = 4_294_967_295;
long myLong = 9_223_372_036_854_775_807;

// числа з плаваючою комою
// float, double, decimal

// float = ±1.5 x 10^−45 - ±3.4 x 10^38 - 4 байти
// double = ±5.0 x 10^−324 - ±1.7 x 10^308 - 8 байтів
// decimal = ±1.0 x 10^-28 - ±7.9 x 10^28 - 16 байтів

//Console.WriteLine(43.65 + 61.11);

double myDouble = 43.65;
float myFloat = 43.65f;
decimal myDecimal = 43.65M;

// рядки
// string
string myString = "string value\nnext line";
char myChar = 'C';


// конвертація
// double => string
string convertedDouble = myDouble.ToString();
// int => string
string convertedInt = 12355.ToString();
// string => double
double convertedDoubleToString = double.Parse("11656.25");
// byte => int
int convertedByteToInt = myByte;
// uint => byte
byte convertedIntToByte = (byte)myUint;
// long => int
//int convertedInt2 = Convert.ToInt32(myLong);

// виведення та зчитування інформації
Console.WriteLine("Enter your name:"); // виведення
string input = Console.ReadLine(); // зчитування

Console.WriteLine("Hello " + input);

Console.WriteLine("Enter your surname:");
input = Console.ReadLine();

Console.WriteLine("Hello " + input);