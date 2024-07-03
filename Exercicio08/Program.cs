//aula 169
Console.WriteLine("Generics e Coleções Genéricas - Exercícios\n");
Console.WriteLine("Escreva um programa para adicionar dois números inteiros usando o conceito de Generics\n");

AdicionaNumeros<int> adicionaInteiros = new AdicionaNumeros<int>();
Console.Write("Informe o primeiro número: ");

var num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o segundo número: ");

var num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nOs números adicionados foram {num1} e {num2}!");
Console.ReadKey();
public class AdicionaNumeros<T> where T : struct, IComparable, IConvertible,
IFormattable
{
    public T Adiciona(T num1, T num2)
    {
        dynamic dynamicNum1 = num1;
        dynamic dynamicNum2 = num2;
        return dynamicNum1 + dynamicNum2;
    }
}