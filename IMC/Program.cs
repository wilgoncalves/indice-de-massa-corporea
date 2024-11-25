using IMC.Entities;
using IMC.Services;
using System.Globalization;

Console.WriteLine("CALCULADORA DE IMC");
Console.WriteLine("-------------------");
Console.WriteLine("Vamos descobrir o seu Índice de Massa Corpórea (IMC)");
Console.WriteLine("Digite seu nome abaixo: ");
string name = Console.ReadLine()!;
Console.WriteLine("Qual seu gênero? (M/F)");
string gender = Console.ReadLine()!.ToUpper();

Console.WriteLine();
Console.WriteLine("Insira seu peso em quilos: ");
double weight = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.WriteLine("Informe sua altura em metros: ");
double height = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.WriteLine();

User user = new User(name, gender, weight, height);

double imc = Calculator.GetImc(user);
string result = Calculator.Classification(imc);

Console.WriteLine($"{name}, seu IMC é: {imc.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine(result);
