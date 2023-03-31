// dinheiro gasto ultrapassou salário-orçamento estourado
// dinheiro gasto foi menor que o salário-gastos dentro do orçamento 

int salario;
int dinheiroGasto;

Console.WriteLine($"Informe o seu salário: ");
salario = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o seu dinheiro gasto: ");
dinheiroGasto = int.Parse(Console.ReadLine());

if (salario > dinheiroGasto)
{
    Console.WriteLine($"Os gastos estão dentro do orçamento");
}

if (salario < dinheiroGasto)
{
    Console.WriteLine($"Orçamento estourado ");
}
