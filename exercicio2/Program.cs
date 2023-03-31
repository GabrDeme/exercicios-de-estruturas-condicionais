

int numeroDeGolsPrimeiroTime;
int numeroDeGolsSegundoTime;

Console.WriteLine($"Informe o numero de gols do primeiro time: ");
numeroDeGolsPrimeiroTime = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o numero de gols do segundo time: ");
numeroDeGolsSegundoTime = int.Parse(Console.ReadLine());

if (numeroDeGolsPrimeiroTime > numeroDeGolsSegundoTime)
{
    Console.WriteLine($"A vitória foi do primeiro time");
}

if (numeroDeGolsPrimeiroTime < numeroDeGolsSegundoTime)
{
    Console.WriteLine($"A vitória foi do segundo time");
}

if (numeroDeGolsPrimeiroTime == numeroDeGolsSegundoTime)
{
    Console.WriteLine($"O resultado final foi empate");
}
