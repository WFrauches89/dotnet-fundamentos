// See https://aka.ms/new-console-template for more information
using Fundamentos.Commom.Models;

Console.WriteLine("Hello, World!");

int quantidade = 1;
string apresentacao = "Olá, seja bem vindo";
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;
DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


DateTime dataFutura = DateTime.Now.AddDays(5);
DateTime dataFuturaAno = DateTime.Now.AddYears(5);

Console.WriteLine(dataFutura);
Console.WriteLine(dataFuturaAno);


Console.WriteLine("Valor armazenado quantidade: " + quantidade);
Console.WriteLine("Valor armazenado apresentação " + apresentacao);
Console.WriteLine("Valor armazenado altura: " + altura);
Console.WriteLine("Valor armazenado preço: " + preco);
Console.WriteLine("Valor armazenado condição: " + condicao);

quantidade = 15;
Console.WriteLine("Valor armazenado quantidade: " + quantidade);

Pessoa p = new Pessoa();


p.Nome = "Hello World";
p.Idade = 35;

p.Apresentar();


Calculadora calculadora = new Calculadora();

calculadora.Somar(15, 20);
calculadora.Subtrair(15, 20);
calculadora.Multiplicar(15, 20);
calculadora.Dividir(150, 20);
calculadora.Potencia(5, 2);

calculadora.Seno(30);
calculadora.Coseno(30);
calculadora.Tangente(30);

calculadora.RaizQuadrada(25);


int numero = 10;

for (int i = 1; i <= numero; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}


int ia = 1;
Console.WriteLine("While");
while (ia <= numero)
{
    Console.WriteLine($"{numero} x {ia} = {numero * ia}");


}

Console.WriteLine("Do-While");
double soma = 0, number = 0, contador = 0;
Console.WriteLine("Caso queira sair digite 0");
do
{
    Console.WriteLine("Digite um número: ");


    soma += number;
    contador++;
    Console.WriteLine($"Valor do momento {soma}");

} while (number != 0);

Console.WriteLine($"Valor do momento {soma}, com o total de {contador} inserções e uma média de {Math.Round(soma / (contador - 1), 2)}");

string opcao;
bool exibirMenu = true;



int[] arrayInteirosA = new int[4];
int[] arrayInteirosB = { 23, 15, 10, 5, 108, 2 };



arrayInteirosA[0] = 25;
arrayInteirosA[1] = 2;
arrayInteirosA[2] = 5;
arrayInteirosA[3] = 125;

Console.WriteLine("Array com for");
for (int i = 0; i < arrayInteirosA.Length; i++)
{
    Console.WriteLine($"Posição {i} do array - valor armazenado {arrayInteirosA[i]} ");
};

Console.WriteLine("Array com foreach");
int cont = 0;
foreach (int valor in arrayInteirosB)
{
    Console.WriteLine($"Posição {cont} do array - valor armazenado {valor}");
    cont++;
};

// Array.Resize(ref arrayInteirosA, arrayInteirosA.Length * 2);
int[] arrayInteirosC = new int[arrayInteirosA.Length * 3];
Array.Copy(arrayInteirosA, arrayInteirosC, arrayInteirosA.Length);

Console.WriteLine("Array com foreach arrayCopy");
int cont2 = 0;
foreach (int valor in arrayInteirosC)
{
    Console.WriteLine($"Posição {cont2} do array - valor armazenado {valor}");
    cont2++;
};

List<string> arrayStrings = new List<string>();

arrayStrings.Add("Nova");
arrayStrings.Add("Lista");
arrayStrings.Add("De");
arrayStrings.Add("Elementos");
arrayStrings.Add("Sendo");
arrayStrings.Add("Adicionados");

Console.WriteLine($"QTD Itens na lista: {arrayStrings.Count}");
Console.WriteLine($"Capacidade Itens na lista: {arrayStrings.Capacity}");

arrayStrings.Add("Outras Palavras");
arrayStrings.Add("Outras Palavras2");
arrayStrings.Add("Outras Palavras3");

Console.WriteLine($"QTD Itens na lista: {arrayStrings.Count}");
Console.WriteLine($"Capacidade Itens na lista: {arrayStrings.Capacity}");

arrayStrings.Remove("De");

Console.WriteLine($"QTD Itens na lista: {arrayStrings.Count}");
Console.WriteLine($"Capacidade Itens na lista: {arrayStrings.Capacity}");


Console.WriteLine("Array com foreach arrayStrings");
foreach (string str in arrayStrings)
{
    Console.WriteLine(str);
}


Console.WriteLine("Array com for arrayStrings");

for (int contador2 = 0; contador2 < arrayStrings.Count; contador2++)
{
    Console.WriteLine(arrayStrings[contador2]);
}

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite sua Opção:");
    Console.WriteLine("1 - Cadastrar Cliente:");
    Console.WriteLine("2 - Buscar Cliente:");
    Console.WriteLine("3 - Apagar Cliente:");
    Console.WriteLine("4 - Encerrar:");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastrar Client.");
            break;
        case "2":
            Console.WriteLine("Buscar Cliente.");
            break;
        case "3":
            Console.WriteLine("Apagar Client.");
            break;
        case "4":
            Console.WriteLine("Encerrando o programa.");
            // Environment.Exit(0);
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Digite uma opção válida.");
            break;
    }

}


Console.WriteLine("Bye ...");