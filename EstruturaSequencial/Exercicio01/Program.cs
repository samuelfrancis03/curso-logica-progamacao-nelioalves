using System.Globalization;

double largura, comprimento, metroQuadrado, area, preco;

largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
metroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

area = largura * comprimento;
preco = area * metroQuadrado;

Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));