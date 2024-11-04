// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Tipos de dados Primitivos
//Numeros inteiros
short ano = 2025;
Console.WriteLine(ano);

int contador = 10;
Console.WriteLine(contador);

long populacaoMundial = 7800000000;
Console.WriteLine(populacaoMundial);

// Numeros de ponto flutuante
float temperatura = 43.6f;
Console.WriteLine(temperatura);

double precoProduto = 199.90;
Console.WriteLine(precoProduto);

//Caracter
char inicial = 'W';
Console.WriteLine(inicial);

//Tipos  Logicos
bool estaLogado = true;
Console.WriteLine(estaLogado);

bool ativo = false;
Console.WriteLine(ativo);

// Tipos de dados Nao primitivos 
string saudacao = "Olá mundo!";
Console.WriteLine(saudacao);

//Nullable Types
int? idade= null;
Console.WriteLine(idade);

//Arrays
int[] numeros = {1, 2, 3, 4, 5};
Console.WriteLine(numeros);

string[] nomes = {"Paulo Andre", "Joel Fernandes", "Lidia Fernandes"};
Console.WriteLine(nomes);

//Classes
public class Pessoa{

    public required string Nome;
    public int idade;
}

//Structs 
public class Ponto
{
    public int X;
    public int Y;
}

//Enums 
public enum diaDaSemana
{
    Segunda, Terca, Quarta, Quinta, Sexta, Sabado, Domingo
}

//Interfaces
public interface IVeiculo
{
    void Mover();
}

// Delegates 
public delegate int Processar(int numero);



