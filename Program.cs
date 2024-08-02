// See https://aka.ms/new-console-template for more information

using ExplorandoLinguagemCSharp.Models;
using Newtonsoft.Json;

// (int, string, string, decimal) tupla = (10, "Leonardo", "Buta", 1.68M);
// (int Id, string Nome, string Sobrenome, decimal Altura) tupla2 = (10, "Leonardo", "Buta", 1.68M);
// ValueTuple<int, string, string, decimal> tupla3 = (10, "Leonardo", "Buta", 1.68M);
// var tupla4 = Tuple.Create(10, "Leonardo", "Buta", 1.68M);


// Console.WriteLine(tupla2.Id);
// Console.WriteLine(tupla2.Nome);
// Console.WriteLine(tupla2.Sobrenome);
// Console.WriteLine(tupla2.Altura);
// Console.WriteLine("************");


// Console.WriteLine(tupla2.Nome.CompareTo(tupla.Item2));

// Console.WriteLine("************");
// Console.WriteLine(tupla.Item1);
// Console.WriteLine(tupla.Item2);
// Console.WriteLine(tupla.Item3);
// Console.WriteLine(tupla.Item4);
// Console.WriteLine(tupla.GetHashCode());
// Console.WriteLine(tupla.GetType());
// Console.WriteLine(tupla);


// LeituraArquivo leituraArquivo = new LeituraArquivo();

// var (sucess, linhasArquivo, quantidadeLinhas) = leituraArquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// // var (sucess, linhasArquivo, quantidadeLinhas) = leituraArquivo.LerArquivo("caminhoErrado");

// if (sucess)
// {
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
//     Console.WriteLine($"Quantidade de linhas no arquivo: {quantidadeLinhas}");
// }
// else
// {
//     Console.WriteLine("NÃO FOI POSSÍVEL LER O ARQUIVO.");
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }

// }







// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("MG", "Minas Gerais");
// estados.Add("SP", "São Paulo");

// foreach (KeyValuePair<string, string> estado in estados)
// {
//     Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
// }

// Console.WriteLine($"Removendo ");
// estados.Remove("MG");
// Console.WriteLine($"Alterando ");

// estados["SP"] = "São Paulo - Alterado";
// foreach (KeyValuePair<string, string> estado in estados)
// {
//     Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
// }

// Console.WriteLine("*****************");
// Console.WriteLine("*****************");
// Console.WriteLine("*****************");

// estados.Remove("SP");
// estados.Add("MG", "Minas Gerais");
// estados.Add("SP", "São Paulo");
// foreach (KeyValuePair<string, string> estado in estados)
// {
//     Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
// }

// string chaveSearch = "BA";

// if (estados.ContainsKey(chaveSearch))
// {
//     Console.WriteLine($"Valor existente: {chaveSearch}");
// }
// else
// {
//     Console.WriteLine($"É seguro adicionar: {chaveSearch}");
// }

// Console.WriteLine("Estado - " + estados["MG"]);
// // estados.Clear();

// // foreach (KeyValuePair<string, string> estado in estados)
// // {
// //     Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
// // }

// Console.WriteLine("*****************");
// Console.WriteLine("*****************");
// Console.WriteLine("*****************");

// // estados.Add("SP", "São Paulo");
// // foreach (KeyValuePair<string, string> estado in estados)
// // {
// //     Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
// // }
// // estados.Add("SP2", "São Paulo");
// // foreach (KeyValuePair<string, string> estado in estados)
// // {
// //     Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
// // }


// Stack<string> novaPilha = new Stack<string>();

// Console.WriteLine("Pratos chegando na cozinha...");
// novaPilha.Push("x");
// novaPilha.Push("r");
// novaPilha.Push("m");
// novaPilha.Push("e");
// novaPilha.Push("d");
// novaPilha.Push("b");
// novaPilha.Push("a");

// foreach (string i in novaPilha)
// {
//     Console.WriteLine(i);
// }
// Console.WriteLine($"Menos um prato, o prato {novaPilha.Pop()} foi lavado");
// Console.WriteLine($"Ops, o prato {novaPilha.Peek()} ia ser lavado mas acabou a água");

// foreach (string i in novaPilha)
// {
//     Console.WriteLine(i);
// }

// Console.WriteLine("Pratos chegando na cozinha...");
// novaPilha.Push("z");
// novaPilha.Push("t");

// foreach (string i in novaPilha)
// {
//     Console.WriteLine(i);
// }

// Console.WriteLine($"Menos um prato, o prato {novaPilha.Pop()} foi lavado");

// foreach (string i in novaPilha)
// {
//     Console.WriteLine(i);
// }


// Queue<int> novaFila = new Queue<int>();

// novaFila.Enqueue(12);
// novaFila.Enqueue(1);
// novaFila.Enqueue(2);
// Console.WriteLine("Trabalhando com filas Enqueue- itens adicionados");
// foreach (int i in novaFila)
// {
//     Console.WriteLine(i);
// }
// novaFila.Enqueue(120);
// novaFila.Enqueue(10);
// novaFila.Enqueue(20);
// novaFila.Enqueue(0);

// Console.WriteLine("Trabalhando com filas Enqueue- itens adicionados");
// foreach (int i in novaFila)
// {
//     Console.WriteLine(i);
// }
// Console.WriteLine("Trabalhando com filas Dequeue- itens removidos");

// Console.WriteLine($"fila andou, o {novaFila.Dequeue()} saiu da fila");
// Console.WriteLine($"fila andou, o {novaFila.Dequeue()} saiu da fila");
// Console.WriteLine($"fila andou, o {novaFila.Dequeue()} saiu da fila");


// foreach (int i in novaFila)
// {
//     Console.WriteLine(i);
// }


// ExceptionsModels em = new ExceptionsModels();

// em.Metodo1("a");

//Usando Deconstruct
Pessoa p6 = new Pessoa("LeonardoOoOoOoO", "Butante");

(string nomeDoDeconstruct, string sobrenomeDoDeconstruct) = p6;

Console.WriteLine($"{nomeDoDeconstruct} {sobrenomeDoDeconstruct} Recebido por deconstruct");

// Pessoa p5 = new Pessoa(nome: "Zaluninho", sobrenome: "Buta", idade: 1);

// Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Buta", idade: 19);

// Pessoa p2 = new Pessoa();

// p2.Nome = "Maria";
// p2.Sobrenome = "Buta";
// p2.Idade = 18;

// Pessoa p3 = new Pessoa("Luiz", "Buta");

// p3.Idade = 22;

// Pessoa p4 = new Pessoa(nome: "Aluno", sobrenome: "Buta", idade: 119);

// Pessoa p6 = new Pessoa(nome: "Leonardo", sobrenome: "Buta", idade: 20);


// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "Buta English Course";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p5);
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.AdicionarAluno(p3);
// cursoDeIngles.AdicionarAluno(p4);
// cursoDeIngles.ListarAlunosNomeCompleto();

// int number = cursoDeIngles.GetNumberOfAlunos(cursoDeIngles.Alunos);

// Console.WriteLine($"Número de alunos matriculados: {number}");

// try
// {
//     string[] linhas = File.ReadAllLines("./Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// }
// catch (FileNotFoundException e)
// {
//     Console.WriteLine("Arquivo não encontrado - " + e.Message);
// }
// catch (DirectoryNotFoundException e)
// {
//     Console.WriteLine("Diretório não encontrado - " + e.Message);
// }
// catch (Exception e)
// {
//     Console.WriteLine(e.Message);
// }
// finally
// {
//     Console.WriteLine("Chegou em finally!");
// }


int numberOFive = 20;

// Utilizando IF
if (numberOFive % 2 == 0) Console.WriteLine($"IF - Comum ----- >O número {numberOFive} é par");
else Console.WriteLine($"IF - Comum ----- >O número {numberOFive} é ímpar");


bool ehPar = numberOFive % 2 == 0;

//Utlizando 
Console.WriteLine($"IF - Ternário ----- > O número {numberOFive} é " + (ehPar ? "par" : "ímpar"));

//Utilizando Método Extensão

int numberOFiveMetodoExtensao = 25;

Console.WriteLine($"Método Extensão ---- > O número {numberOFiveMetodoExtensao} é " + (numberOFiveMetodoExtensao.EhPar() ? "par" : "ímpar"));

//Trabalhando com JSON Serialize

// List<Venda> vendas = new List<Venda>();

// //DateTime - ISO8601 Format Date Time

// Venda v1 = new Venda(01, "Vassoura", 15.25M, DateTime.Now);
// Venda v2 = new Venda(02, "Pá", 5.75M, DateTime.Now);
// Venda v3 = new Venda(03, "Rodo Mágico", 105.00M, DateTime.Now);

// vendas.Add(v1);
// vendas.Add(v2);
// vendas.Add(v3);

// string serializandoLista = JsonConvert.SerializeObject(vendas);
// string serializandoListaIdentado = JsonConvert.SerializeObject(vendas, Formatting.Indented);

// string v1Serializado = JsonConvert.SerializeObject(v1);
// string v1SerializadoIdentado = JsonConvert.SerializeObject(v1, Formatting.Indented);

// File.WriteAllText("./Arquivos/venda.json", v1Serializado);
// File.WriteAllText("./Arquivos/vendaidentada.json", v1SerializadoIdentado);

// File.WriteAllText("./Arquivos/vendas.json", serializandoLista);
// File.WriteAllText("./Arquivos/vendasidentada.json", serializandoListaIdentado);

// Console.WriteLine(v1Serializado);
// Console.WriteLine(v1SerializadoIdentado);

// //Trabalhando com JSON DeserializeObject


// string conteudoArquivo = File.ReadAllText("./Arquivos/vendasidentada.json");

// List<VendaForDeserializeObject> listaDeserializados =
//             JsonConvert.DeserializeObject<List<VendaForDeserializeObject>>(conteudoArquivo);

// foreach (VendaForDeserializeObject itemVenda in listaDeserializados)
// {
//     Console.WriteLine($"Id: {itemVenda.Id}, Produto: {itemVenda.Produto}, "
//                       + $" Preço: {itemVenda.Preco}, "
//                       + $" Data da Venda: {itemVenda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
// }

MyArray<string> myArray = new MyArray<string>();
MyArray<int> myArray2 = new MyArray<int>();

myArray.AdicionarNaLista("Primeiro item da lista");
myArray.AdicionarNaLista("Segundo item da lista");
myArray.AdicionarNaLista("Terceiro item da lista");
myArray.AdicionarNaLista("Quarto item da lista");

myArray2.AdicionarNaLista(15);
myArray2.AdicionarNaLista(5);
myArray2.AdicionarNaLista(125);
myArray2.AdicionarNaLista(150);
myArray2.AdicionarNaLista(105);
myArray2.AdicionarNaLista(215);
myArray2.AdicionarNaLista(152);
myArray2.AdicionarNaLista(1);
myArray2.AdicionarNaLista(2);
myArray2.AdicionarNaLista(20);
myArray2.AdicionarNaLista(21); // não inserido excedeu limite

Console.WriteLine(myArray2[9]);

Console.WriteLine(myArray[0]);
Console.WriteLine(myArray[3]);
Console.WriteLine(myArray[2]);
Console.WriteLine(myArray[1]);


// internal class Venda
// {
//     public Venda(int id, string produto, decimal preco, DateTime dataVenda)
//     {
//         this.Id = id;
//         this.Produto = produto;
//         Preco = preco;
//         DataVenda = dataVenda;

//     }
//     public int Id { get; set; }
//     public string Produto { get; set; }
//     public decimal Preco { get; set; }
//     public DateTime DataVenda { get; set; }
// }


