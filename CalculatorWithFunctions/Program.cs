int a = 5;
int b = 6;

Add(a, b);
Add(1000, 500);

Sub(a, b);
Sub(1000, 500);

Mul(a, b);
Mul(1000, 500);

Div(a, b);
Div(1000, 500);

static void Add(int x, int y)
{
    Console.WriteLine($"{x}+{y}={x + y}");
}
static void Sub(int x, int y)
{
    Console.WriteLine($"{x}-{y}={x - y}");
}
static void Mul(int x, int y)
{
    Console.WriteLine($"{x}*{y}={x * y}");
}
static void Div(int x, int y)
{
    Console.WriteLine($"{x}/{y}={(double) x / y}");
}
