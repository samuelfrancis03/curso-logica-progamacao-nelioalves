using System.Globalization;

Console.WriteLine("Exercicios Resolvidos: ");
Console.WriteLine("Escolha um Exercicio");

Console.WriteLine("""
    1 - Estrutura Condicional - Exercicio 1
    2 - Estrutura Condicional - Exercicio 2
    3 - Estrututa Repeticao (While) - Exercicio 1
    4 - Estrututa Repeticao (While) - Exercicio 2
    5 - Estrututa Repeticao (For) - Exercicio 3
    6 - Estrututa Repeticao (For) - Exercicio 4
    7 - Estrututa Repeticao (Do While) - Exercicio 1
    8 - Estrututa Repeticao (Foreach) - Exercicio 1

    """);

int entrada = int.Parse(Console.ReadLine());


switch (entrada) {

    case 1:
        Console.WriteLine("Estrutura Condicional - Exercicio 1");
        EstruturaCondicional01();
        break;

    case 2:
        Console.WriteLine("Estrutura Condicional - Exercicio 2");
        EstruturaCondicional02();
        break;

    case 3:
        Console.WriteLine("Estrutura Repeticao - Exercicio 1");
        EstruturaRepeticaoWhile1();
        break;

    case 4:
        Console.WriteLine("Estrutura Repeticao - Exercicio 2");
        EstruturaRepeticaoWhile2();
        break;

    case 5:
        Console.WriteLine("Estrutura Repeticao - Exercicio 3");
        EstrututuraRepeticaoFor1();
        break;

    case 6:
        Console.WriteLine("Estrutura Repeticao - Exercicio 3");
        EstrututuraRepeticaoFor2();
        break;

    case 7:
        Console.WriteLine("Estrutura Repeticao - Exercicio 1");
        EstruturaDeRepeticaoDoWhie();
        break;

    case 8:
        Console.WriteLine("Estrutura Repeticao - Exercicio 1");
        EstruturaDeRepeticaoForEach();
        break;

}



static void EstruturaCondicional01() {
    
    double nota1, nota2, notaFinal;
    Console.WriteLine("Digite o valor da nota 1: ");
    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Digite o valor da nota 2: ");
    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    notaFinal = nota1 + nota2;

    Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));

    if (notaFinal < 60.0) {

        Console.WriteLine("REPROVADO");

    } else
    {
        Console.WriteLine("APROVADO");
    }


}

static void EstruturaCondicional02()
{

    double A, B, C, delta, baskara1, baskara2;

    string[] vet = Console.ReadLine().Split(' ');
    A =  double.Parse(vet[0]);
    B = double.Parse(vet[1]);
    C = double.Parse(vet[2]);

    delta = Math.Pow(B, 2) - 4 * A * C;

    if (delta >= 0 && A != 0)
    {

        baskara1 = (-B + Math.Sqrt(delta)) / (2 * A);
        baskara2 = (-B - Math.Sqrt(delta)) / (2 * A);


        Console.WriteLine("R1 = " + baskara1.ToString("F5", CultureInfo.InvariantCulture));
        Console.WriteLine("R2 = " + baskara2.ToString("F5", CultureInfo.InvariantCulture));

    }
    else
    {

        Console.WriteLine("Impossivel Calcular");
    }

}

static void EstruturaRepeticaoWhile1()
{

    int A, B;
    string[] vet = Console.ReadLine().Split(' ');
    A = int.Parse(vet[0]);
    B = int.Parse(vet[1]);


    while (A != B)
    {


        if (A > B)
        {
            Console.WriteLine("Decrescente");
        }
        else if (A < B)
        {
            Console.WriteLine("Crescente");
        }
        else
        {
            Console.WriteLine("Iguais");
        }

        vet = Console.ReadLine().Split(' ');
        A = int.Parse(vet[0]);

        B = int.Parse(vet[1]);

    }






}


static void EstruturaRepeticaoWhile2()
{
    double idadeMedia = 0.0;
    int soma = 0;
    int incremento = 0;
    int idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (idade > 0)
    {

        while (idade >= 0)
        {

            soma += idade;
            incremento++;

            idadeMedia = (double) soma / incremento;

            idade = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(idadeMedia.ToString("F2", CultureInfo.InvariantCulture));
    }
    else {
        Console.WriteLine("Impossivel Calcular");
    }
}

static void EstrututuraRepeticaoFor1() {
    
    int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    int multiplicação;


    for (int i = 1; i <= 10; i++) { 
    
        multiplicação = numero * i;
        Console.WriteLine(i + " x " + numero + " = " + multiplicação);

    }


}


static void EstrututuraRepeticaoFor2()
{

    int x = 0, y = 0, menor = 0, maior = 0, impar = 0;

    x = int.Parse(Console.ReadLine());
    y = int.Parse(Console.ReadLine());

    if (x > y)
    {
        maior = x;
        menor = y;
    }
    else
    {
        maior = y;
        menor = x;
    }


    for (int i = menor + 1; i < maior; i++) {

            if (i % 2 != 0) {
                impar += i;
            } 
    }

    Console.WriteLine(impar);

}

static void EstruturaDeRepeticaoDoWhie() {

    double f, c;
    string rep;

    do
    {
        Console.Write("Digite a temperatura em Celsius: ");
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        f = (9 * c) / 5 + 32;

        Console.WriteLine("Equivalente em Fahrenheit: " + f.ToString("F1", CultureInfo.InvariantCulture));
        Console.Write("Deseja repetir (s/n)?");
        rep = Console.ReadLine();



    } while (rep != "n");
   

}


static void EstruturaDeRepeticaoForEach() 
{

    int n;
    string[] nomes;

    n = int.Parse(Console.ReadLine());
    nomes = new string[n];

    for (int i = 0; i < n; i++) 
    {
        nomes[i] = Console.ReadLine();
    }

    Console.WriteLine("Nomes lidos: ");
    foreach (string nome in nomes)
    {
        Console.WriteLine(nome);
    }



}




