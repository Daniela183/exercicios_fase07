Console.WriteLine("Generics e Coleções Genéricas - Exercícios\n");
Console.WriteLine("Escreva um programa seguindo as seguintes orientações:" +
    "\r\n1. Declare um método genérico chamado ReverterEImprimir em uma classe não genérica chamada Exemplo." +
    "\r\n2. O método recebe como parâmetro um array de qualquer tipo. " +
    "\r\n3. A seguir declare três tipos diferentes de array: um array de int , um array de strings e um array de double" +
    "\r\n4. Invoque o método duas vezes com cada array. " +
    "\r\n5. Na primeira vez invoque o método com um determinado array, onde ele usa explicitamente o parâmetro de tipo. " +
    "\r\n6. Na segunda vez, invoque o método onde o tipo é inferido\n");

int[] intArray = { 1, 2, 3, 4, 5 };
string[] stringArray = { "Lucas", "Rafael", "Larissa", "João" };
double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };

foreach (int i in intArray)
{
    Console.WriteLine(i);
}
Console.WriteLine();

foreach (string s in stringArray)
{
    Console.WriteLine(s);
}
Console.WriteLine();

foreach (double d in doubleArray)
{
    Console.WriteLine(d);
}
Console.WriteLine();

Console.WriteLine("-Array de Inteiros: ");
Exemplo.ReverterEImprimir<int>(intArray);
Exemplo.ReverterEImprimir(intArray);

Console.WriteLine("\n-Array de Strings: ");
Exemplo.ReverterEImprimir<string>(stringArray);
Exemplo.ReverterEImprimir(stringArray);

Console.WriteLine("\n-Array de Doubles: ");
Exemplo.ReverterEImprimir<double>(doubleArray);
Exemplo.ReverterEImprimir(doubleArray);

Console.ReadKey();
class Exemplo
{
    public static void ReverterEImprimir<T>(T[] array)
    {
        Array.Reverse(array);
        Console.WriteLine("Array Revertido: ");
        foreach (T item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}