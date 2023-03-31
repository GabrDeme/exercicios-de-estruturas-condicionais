// As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia;
// se forem compradas pelo menos doze passam a custarR$ 0,25;


int macas;
float compra;
Console.WriteLine($"Digite a quantidade de maçãs compradas: ");
macas = int.Parse(Console.ReadLine());

if (macas >= 12)
{
   compra= ((float)((float)macas * 0.25));
}
else 
{
   compra= (float)(macas * 0.30);
}
Console.WriteLine($"o valor de sua compra é R${compra}");