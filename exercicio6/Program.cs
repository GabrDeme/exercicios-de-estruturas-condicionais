int frequencia;
int media;

Console.WriteLine($"Digite a frequência do aluno: ");
frequencia = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a média do aluno: ");
media = int.Parse(Console.ReadLine());

if (frequencia >= 75 && media >= 7.0)
{
    Console.WriteLine($"O aluno foi aprovado ");
}
else if (frequencia >= 75 && media <= 3.0)
{
    Console.WriteLine($"Será necessário fazer uma reavaliação do aluno");
}
else 
{
    Console.WriteLine($"O aluno foi reprovado");
}
