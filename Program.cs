// Задача 19.

bool Palindrom(int num)
{
int a = num / 10000;
int b = num % 10;
if (a == b)
{
    a = num / 1000;
    a = a % 10;
    b = num % 100;
    b = b / 10;
    if(a == b) return true;
    return false;
}
else
    return false;
}

Console.Write("Input a palindrom: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = Palindrom(num);
Console.Write(result);

// Задача 21.

double Distance(double xA, double xB, double yA, double yB, double zA, double zB)
{
    double x = Math.Pow(xA,2) - Math.Pow(xB,2);
    double y = Math.Pow(yA,2) - Math.Pow(yB,2);
    double z = Math.Pow(zA,2) - Math.Pow(zB,2);
    double result = Math.Sqrt(x+y+z);
    return result;
}

Console.Write("Input a starting x coordinate = ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an end x coordinate = ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a starting y coordinate = ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an end y coordinate = ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a starting z coordinate = ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an end z coordinate = ");
double zB = Convert.ToDouble(Console.ReadLine());

double result1 = Distance(xA, xB, yA, yB, zA, zB);
Console.Write($"The length of the segment A({xA}, {yA}, {zA}) and B({xB}, {yB}, {zB}) = {result1}");

// Задача 23.

void Pow(int num)
{
    for(double step = 1;step <= num; step++)
    {
        double a = Math.Pow(step, 3);
        Console.Write(a + " ");
    }
}

Console.Write("Input a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Pow(num1);