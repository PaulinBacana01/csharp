﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Tipos de dados Primitivos
//Numeros inteiros
short ano = 2025;
int contador = 10;
long polulacaoMundial = 7800000000;

// Numeros de ponto flutuante
float temperatura = 43.6f;
double precoProduto = 199.90;

//Caracter
char inicial = "W";

//Tipos  Logicos
bool estaLogado = true;
bool ativo = false;

// Tipos de dados Nao primitivos 
string saudacao = "Olá mundo!";

//Arrays
int[] numeros = {1, 2, 3, 4, 5};
string[] nomes = {"Paulo Andre", "Joel Fernandes", "Lidia Fernandes"};

//Classes
public class Pessoa{

    public string Nome;
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
public void Delegates Processar(int numero);

//Nullable Types
int? idade = null;