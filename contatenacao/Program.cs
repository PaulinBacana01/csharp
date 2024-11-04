// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string nome = "jao";
string saudacao= "ola,"+nome+ "! Bem-Vindo.";

Console.WriteLine(saudacao);

string nome = "jao2";
string saudacao1= $"ola,"{nome} "! Bem-Vindo.";
Console.WriteLine(saudacao2);

int numero = 5;

Console.WriteLine (numero.GetType());
Console.WriteLine (typeof(int));

string valorTexto="100";
Console.WriteLine("A variávelvalor é o tipo:"+valorTexto.GetType());

int numero = int.Parse(valorTexto);
Console.WriteLine(numero);
Console.WriteLine("A variavel numeroParse é do tipo:" + numero.GetType());


