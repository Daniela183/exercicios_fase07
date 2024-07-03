//aula 158
Console.WriteLine("Exercício - Dictionary");
Console.WriteLine("Alunos e Notas \n");

var alunos = new Dictionary<int, Aluno>()
{
    { 1, new Aluno("Maria\t",7) },
    { 2, new Aluno("Eric \t", 8) },
    { 3, new Aluno("Ana \t", 9 ) },
    { 4, new Aluno("Alex \t", 6) },
    { 5, new Aluno("Diná \t", 5) }
};

ExibirColecao(alunos);
do
{
Console.Write("\nInforme o código do Aluno a localizar (0 sai): ");
int codigo = Convert.ToInt32(Console.ReadLine());

if (codigo == 0)
break;

var resultado = alunos.ContainsKey(codigo);
if (resultado)
{
Console.Write("Informe a nota (1 a 10): ");
var nota = Convert.ToInt32(Console.ReadLine());
alunos[codigo].Nota = nota;
}
else
{
Console.WriteLine("Aluno não localizado");
}
}
while (true);
ExibirColecao(alunos);

Console.Write("\nInforme o código do Aluno a remover: ");
int cod = Convert.ToInt32(Console.ReadLine());
if (alunos.ContainsKey(cod))
{
alunos.Remove(cod);
Console.WriteLine("\nAluno removido com sucesso");
}
else
{
Console.WriteLine("\nCódigo não encontrado");
}
ExibirColecao(alunos);

Console.WriteLine("\nIncluindo um novo Aluno");
Console.Write("Informe o nome do aluno: ");
string novoNome = Console.ReadLine();

Console.Write("Informe a nota do aluno: ");
int novaNota = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o código do aluno: ");
int novoCodigo = Convert.ToInt32(Console.ReadLine());


if (!alunos.ContainsKey(novoCodigo))
{
alunos.Add(novoCodigo, new Aluno(novoNome, novaNota));
Console.WriteLine($"\nAluno incluido com sucesso: {novoNome}");
}
else
{
Console.WriteLine("\nCódigo já existe encontrado");
}
ExibirColecao(alunos);

Console.WriteLine("\nAlunos ordenados por nome");

var alunosOrdenados = alunos.OrderBy(x => x.Value.Nome);
foreach (var item in alunosOrdenados)
{
Console.WriteLine($"{item.Key} {item.Value.Nome} {item.Value.Nota}");
}

alunos.Clear();
ExibirColecao(alunos);
Console.WriteLine("\nFim do exercício");

Console.ReadKey();

static void ExibirColecao(Dictionary<int, Aluno> alunos)
{
foreach (var item in alunos)
{
Console.WriteLine($"{item.Key} {item.Value.Nome} {item.Value.Nota}");
}
}



public class Aluno
{
    public Aluno(string? nome, int nota)
    {
        Nome = nome;
        Nota = nota;
    }
    public string? Nome { get; set; }
    public int Nota { get; set; }
}