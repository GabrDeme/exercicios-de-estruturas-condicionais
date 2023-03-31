// Triângulo    Equilátero:    possui    os    3    lados    iguais.
// Triângulo    Isóscele:    possui    2    lados    iguais.
// Triângulo    Escaleno:    possui    3    lados    diferentes.


int lado1;
int lado2;
int lado3;

Console.WriteLine($"Informe a medida do primeiro lado do triangulo: ");
lado1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe a medida do segundo lado do triangulo: ");
lado2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe a medida do terceiro lado do triangulo: ");
lado3 = int.Parse(Console.ReadLine());

if (lado1 == lado2 && lado1 == lado3)
{
    Console.WriteLine($"O seu Triângulo é Equilátero");
}

else if (lado1 == lado2 && lado1 != lado3)
{
    Console.WriteLine($"O seu Triângulo é Isósceles");
}

else if (lado1 != lado2 && lado1 != lado3)
{
    Console.WriteLine($"O seu Triângulo é Escaleno");
}


// -------------------------
// |    não é necessário   |
// | colocar esse ultimo if|
// |    corrigir depois    |
// -------------------------