HashSet<string> fruta = new HashSet<string>{"Banana", "ClebinhoHack", "Limao"};
fruta.Add("Banana");
fruta.Add("Limao");

Console.WriteLine("Frutas do Conjunto:");
foreach (string frutas in fruta)
{
    Console.WriteLine(frutas);
}