Console.WriteLine("Generics e Coleções Genéricas - Exercícios\n");
Console.WriteLine("Implemente um programa que verifica se uma expressão matemática contém parênteses balanceados seguindo os seguintes passos:" +
    "\r\n1. Crie uma variável do tipo Stack<char> para armazenar os parênteses abertos." +
    "\r\n2. Percorra cada caractere da expressão matemática." +
    "\r\n3. Se o caractere for um parêntese aberto ( '(', '{', '['), adicione-o à pilha." +
    "\r\n4. Se o caractere for um parêntese fechado ( ')', '}', ']' ), verifique se a pilha não está vazia e se o último " +
    "parêntese aberto adicionado na pilha corresponde ao parêntese fechado atual. Se sim, remova o último parêntese aberto da pilha. " +
    "Caso contrário, a expressão matemática não contém parênteses balanceados." +
    "\r\n5. Após percorrer todos os caracteres da expressão matemática, verifique se a pilha está vazia. Se estiver vazia, a expressão " +
    "matemática contém parênteses balanceados. Caso contrário, a expressão não é balanceada.\n");

string expression = "(1 + 2) * 3) - 4";
bool balenceada = EstaBalanceada(expression);
Console.WriteLine($"A expressão matemática {expression} {(balenceada ? "está balanceada" : "não está balanceada")}.");
Console.ReadKey();
static bool EstaBalanceada(string expression)
{
    Stack<char> stack = new Stack<char>();
    foreach (char c in expression)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            stack.Push(c);
        }
        else if (c == ')' || c == '}' || c == ']')
        {
            if (stack.Count == 0)
            {
                return false;
            }
            char lastParentheses = stack.Pop();
            if ((c == ')' && lastParentheses != '(') ||
            (c == '}' && lastParentheses != '{') ||
            (c == ']' && lastParentheses != '['))
            {
                return false;
            }
        }
    }
    return stack.Count == 0;
}
