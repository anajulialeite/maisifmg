Console.WriteLine("Qual é o seu nome?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Olá, {name}, hoje é dia {currentDate:d} as {currentDate:t}!");
Console.WriteLine($"{Environment.NewLine} Aperte qualquer botão para sair....");
Console.ReadKey(true);
