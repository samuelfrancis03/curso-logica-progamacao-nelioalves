using System.Globalization;



Console.WriteLine("Entre com seu nome completo: ");
string nome = Console.ReadLine();
Console.WriteLine("Qunatos quartos tem na sua casa: ");
int quartos = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com um preço do produto: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre seu último nome, idade, e altura (mesma linha)");
string[] info = Console.ReadLine().Split(' ');
string ultimoNome  = info[0];
int idade = int.Parse(info[1]);
double altura = double.Parse(info[2], CultureInfo.InvariantCulture);

Console.WriteLine("Saida");
Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));