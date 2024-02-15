// Faça um programa que receba a idade de uma pessoa e calcule a idade em meses, dias, horas e minutos.

// algoritmo
// entrada: idade
// processamento: idade multiplicado ou por meses, dias, horas ou minutos

// entrada 

Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine(@$"
/Programinha para calculo de/
/    ☆*: .｡. idade .｡.:*☆/
");
Console.ResetColor();

Console.WriteLine($"Opa meu consagrado, qual o seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Belo nome man, seja bem vindo: {nome} ;)");

Console.WriteLine($"Pode namoralzinha passar sua idade brother?");
int idade = int.Parse(Console.ReadLine());

int meses = idade * 12;
Console.WriteLine($"Sua idade em meses: {meses} ");

int dias = idade * 365;
Console.WriteLine($"Sua idade em dias: {dias} ");

int horas = idade * 8766;
Console.WriteLine($"Sua idade em horas: {horas} ");

int minutos = idade * 525960;
Console.WriteLine($"Sua idade em minutos: {minutos} ");






