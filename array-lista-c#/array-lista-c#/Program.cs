
int[] x = new int[10];
int[] y = new int[10];

for (int i = 0; i < 10; i++)
{
    x[i] = i;
}

Array.Resize(ref x, 20);

Console.WriteLine("=============================");

Array.Resize(ref y, 20);

Array.Copy(x, y, x.Length);

foreach (int i in x ) Console.WriteLine(i);
foreach (int i in y ) Console.WriteLine(i);

List<int> numbers = new List<int>();

Console.WriteLine("=============================");

for(int i = 10; i > 0 ;i--)
{
    numbers.Add(i);
}

foreach (int i in numbers) Console.WriteLine(i);

