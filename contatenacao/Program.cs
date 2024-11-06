// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
string nome = "jao";
string saudacao= "ola, "+nome+ "! Bem-Vindo.";

Console.WriteLine(saudacao);

//

string nome1 = "jao2";
string saudacao1 = $"ola {nome1}! Bem-Vindo.";
Console.WriteLine(saudacao1);

//

int numero = 5;

Console.WriteLine (numero.GetType());
Console.WriteLine (typeof(int));

string valorTexto="100";
Console.WriteLine("A variável valorTexto é o tipo:"+valorTexto.GetType());

int numero1 = int.Parse(valorTexto);
Console.WriteLine(numero1);
Console.WriteLine("A variavel valorTexto é do tipo:" + numero.GetType());

//convert

string valoremTexto = "100";
Console.WriteLine ("A variavel valorTexto e do tipo"+ valoremTexto);
Console.WriteLine ("A variavel valorTexto e do tipo"+ valoremTexto.GetType());

int numeroConvert = Convert.ToInt32(valoremTexto);
Console.WriteLine(numeroConvert);
Console.WriteLine ("A variavel valorTexto e do tipo"+ numeroConvert.GetType());

//para string

int numero2 = 234;
Console.WriteLine(numero2.GetType());

string numbcomostring = numero2.ToString();
Console.WriteLine (numbcomostring.GetType());

//Personalizacao de Formatacao d\para data e hora
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

string dataFormatada = dataAtual.ToString("dd/MM/yyyy");
Console.WriteLine(dataFormatada);

string dataHoraFormatada = dataAtual.ToString("HH:mm:ss");
Console.WriteLine(dataHoraFormatada);

//interpolacao de strings
double preco = 29.99;
Console.WriteLine ($"O preco e: {preco.ToString("C2")}");

//Formatacao de acordo com a localizacao
decimal valor = 1234.56m;
string valorUS = valor.ToString("C", new System.Globalization.CultureInfo
("en-US"));
Console.WriteLine(valorUS);

string valorBR = valor.ToString("C", new System.Globalization.CultureInfo
("pt-BR"));
Console.WriteLine(valorBR);
