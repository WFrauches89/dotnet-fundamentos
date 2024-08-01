// See https://aka.ms/new-console-template for more information

using ExplorandoLinguagemCSharp.Models;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");
estados.Add("SP", "São Paulo");

foreach (KeyValuePair<string, string> estado in estados)
{
    Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
}

Console.WriteLine($"Removendo ");
estados.Remove("MG");
Console.WriteLine($"Alterando ");

estados["SP"] = "São Paulo - Alterado";
foreach (KeyValuePair<string, string> estado in estados)
{
    Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
}

Console.WriteLine("*****************");
Console.WriteLine("*****************");
Console.WriteLine("*****************");

estados.Remove("SP");
estados.Add("MG", "Minas Gerais");
estados.Add("SP", "São Paulo");
foreach (KeyValuePair<string, string> estado in estados)
{
    Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
}

string chaveSearch = "BA";

if (estados.ContainsKey(chaveSearch))
{
    Console.WriteLine($"Valor existente: {chaveSearch}");
}
else
{
    Console.WriteLine($"É seguro adicionar: {chaveSearch}");
}

Console.WriteLine("Estado - " + estados["MG"]);
// estados.Clear();

// foreach (KeyValuePair<string, string> estado in estados)
// {
//     Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
// }

Console.WriteLine("*****************");
Console.WriteLine("*****************");
Console.WriteLine("*****************");

// estados.Add("SP", "São Paulo");
// foreach (KeyValuePair<string, string> estado in estados)
// {
//     Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
// }
// estados.Add("SP2", "São Paulo");
// foreach (KeyValuePair<string, string> estado in estados)
// {
//     Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
// }


Stack<string> novaPilha = new Stack<string>();

Console.WriteLine("Pratos chegando na cozinha...");
novaPilha.Push("x");
novaPilha.Push("r");
novaPilha.Push("m");
novaPilha.Push("e");
novaPilha.Push("d");
novaPilha.Push("b");
novaPilha.Push("a");

foreach (string i in novaPilha)
{
    Console.WriteLine(i);
}
Console.WriteLine($"Menos um prato, o prato {novaPilha.Pop()} foi lavado");
Console.WriteLine($"Ops, o prato {novaPilha.Peek()} ia ser lavado mas acabou a água");

foreach (string i in novaPilha)
{
    Console.WriteLine(i);
}

Console.WriteLine("Pratos chegando na cozinha...");
novaPilha.Push("z");
novaPilha.Push("t");

foreach (string i in novaPilha)
{
    Console.WriteLine(i);
}

Console.WriteLine($"Menos um prato, o prato {novaPilha.Pop()} foi lavado");

foreach (string i in novaPilha)
{
    Console.WriteLine(i);
}


Queue<int> novaFila = new Queue<int>();

novaFila.Enqueue(12);
novaFila.Enqueue(1);
novaFila.Enqueue(2);
Console.WriteLine("Trabalhando com filas Enqueue- itens adicionados");
foreach (int i in novaFila)
{
    Console.WriteLine(i);
}
novaFila.Enqueue(120);
novaFila.Enqueue(10);
novaFila.Enqueue(20);
novaFila.Enqueue(0);

Console.WriteLine("Trabalhando com filas Enqueue- itens adicionados");
foreach (int i in novaFila)
{
    Console.WriteLine(i);
}
Console.WriteLine("Trabalhando com filas Dequeue- itens removidos");

Console.WriteLine($"fila andou, o {novaFila.Dequeue()} saiu da fila");
Console.WriteLine($"fila andou, o {novaFila.Dequeue()} saiu da fila");
Console.WriteLine($"fila andou, o {novaFila.Dequeue()} saiu da fila");


foreach (int i in novaFila)
{
    Console.WriteLine(i);
}


ExceptionsModels em = new ExceptionsModels();

em.Metodo1("a");

Pessoa p5 = new Pessoa(nome: "Zaluninho", sobrenome: "Buta", idade: 1);

Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Buta", idade: 19);

Pessoa p2 = new Pessoa();

p2.Nome = "Maria";
p2.Sobrenome = "Buta";
p2.Idade = 18;

Pessoa p3 = new Pessoa("Luiz", "Buta");

p3.Idade = 22;

Pessoa p4 = new Pessoa(nome: "Aluno", sobrenome: "Buta", idade: 119);

Pessoa p6 = new Pessoa(nome: "Leonardo", sobrenome: "Buta", idade: 20);


Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Buta English Course";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p5);
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.AdicionarAluno(p4);
cursoDeIngles.ListarAlunosNomeCompleto();

int number = cursoDeIngles.GetNumberOfAlunos(cursoDeIngles.Alunos);

Console.WriteLine($"Número de alunos matriculados: {number}");

try
{
    string[] linhas = File.ReadAllLines("./Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

}
catch (FileNotFoundException e)
{
    Console.WriteLine("Arquivo não encontrado - " + e.Message);
}
catch (DirectoryNotFoundException e)
{
    Console.WriteLine("Diretório não encontrado - " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Chegou em finally!");
}