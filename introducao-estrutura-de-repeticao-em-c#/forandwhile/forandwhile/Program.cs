for (int i = 0; i < 11; ++i )
{
    Console.WriteLine( $"{2} * {i} = {2*i}" );
}

int j = 0;

Console.WriteLine("=================");

while (j < 11)
{
    Console.WriteLine($"{3} * {j} = {3 * j}");
    j++;

    if (j == 10) break;
}

Console.WriteLine("=================");

int x = 0;

do
{
    Console.WriteLine($"{4} * {x} = {4 * x}");
    x++;
} while (x < 11);