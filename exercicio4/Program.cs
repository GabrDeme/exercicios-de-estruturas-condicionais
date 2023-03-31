int senha = 1234;

Console.WriteLine($"Informe a sua senha aqui: ");
senha = int.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine($"Sua senha está correta");
}
else
{
    Console.WriteLine($"Sua senha está incorreta");
}