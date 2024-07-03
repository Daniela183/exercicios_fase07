Console.WriteLine("Generics e Coleções Genéricas - Exercícios\n");
Console.WriteLine("Escreva um programa que crie uma lista de objetos Aluno que contém as propriedades: Nome, Idade e Sexo. " +
    "A seguir defina 5 objetos do tipo Aluno e exiba uma lista de objetos alunos no console.\n");

List<Aluno> listaAlunos = new List<Aluno>();
listaAlunos.Add(new Aluno("João", 22, 'M'));
listaAlunos.Add(new Aluno("Maria", 21, 'F'));
listaAlunos.Add(new Aluno("Pedro", 23, 'M'));
listaAlunos.Add(new Aluno("Ana", 20, 'F'));
listaAlunos.Add(new Aluno("Lucas", 24, 'M'));
Console.WriteLine("Lista de Alunos:\n");

foreach (Aluno aluno in listaAlunos)
{
Console.WriteLine($"Nome: {aluno.Nome}\t Idade: {aluno.Idade}\t Sexo: {aluno.Sexo}");
}
Console.ReadKey();
public class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public char Sexo { get; set; }
    public Aluno(string nome, int idade, char sexo)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }
}
