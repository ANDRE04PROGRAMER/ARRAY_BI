Console.WriteLine("Ingrese el tamaño de las matrices (n): ");
int n = int.Parse(Console.ReadLine());

int[,] A = new int[n, n];
int[,] B = new int[n, n];
int[,] C = new int[n, n];

Console.WriteLine("Ingrese los elementos de la matriz A:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"A[{i}, {j}]: ");
        A[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Ingrese los elementos de la matriz B:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"B[{i}, {j}]: ");
        B[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        C[i, j] = A[i, j] + B[i, j];
    }
}

Console.WriteLine("La matriz resultante es: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(C[i, j] + "\t");
    }
    Console.WriteLine();
}