int a = 15;
int b = 0;

double result = 0;

try
{
    result = double.Parse("sqrt");
}
catch
{
    Console.WriteLine("Error");
}

if (double.TryParse("sqrt", out result))
{ 
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Error");
}


// catch
try
{
    Console.WriteLine(a / b);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Divide by zero is forbidden");
}
catch (OverflowException)
{
    Console.WriteLine("Overflow");
}
catch
{
    Console.WriteLine("Something bad happened");
}

int x;

// finally
try
{
    Console.WriteLine(a / b);
    x = 10;
}
catch (Exception ex)
{
    x = 15;

    Console.WriteLine($"Type: {ex.GetType()}");
    Console.WriteLine($"Message: {ex.Message}");
    Console.WriteLine($"StackTrace: {ex.StackTrace}");
    Console.WriteLine("Something bad happened");
}
finally
{

}

//x = 15;

//throw new OverflowException("Overflow happened");



string? input = Console.ReadLine();

Console.WriteLine(double.TryParse(input, out double number) ?
    number : "Incorrect input");

// продовження
Console.WriteLine("End program");

Console.ReadLine();