// See https://aka.ms/new-console-template for more information
using System.Xml;

Console.WriteLine("Digite um num:");
double num = int.Parse(Console.ReadLine());
double soma = 0;
for (int i = 0; i < num; i++){
    soma += num;
}
Console.WriteLine($"Soma dos números antecessores ao digitado: {soma}");
Console.WriteLine("Carlos Daniel");
