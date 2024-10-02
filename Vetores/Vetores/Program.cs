using System.Globalization;

Console.WriteLine("Exercicios Resolvidos: ");


Console.WriteLine("""
    1 - Vetor - Exercicio 1
    2 - Vetor - Exercicio 2
    3 - Vetor - Exercicio 3
    4 - Vetor - Exercicio Propostos 1
    5 - Vetor - Exercicio Propostos 2
    6 - Vetor - Exercicio Propostos 2

    """);
Console.Write("Escolha um Exercicio: ");
int entrada = int.Parse(Console.ReadLine());


switch (entrada)
{

    case 1:
        Console.WriteLine("Vetor - Exercicio 1");
        Exercicio01();
        break;

    case 2:
        Console.WriteLine("Vetor - Exercicio 2");
        Exercicio02();
        break;

    case 3:
        Console.WriteLine("Vetor - Exercicio 3");
        Exercicio03();
        break;

    case 4:
        Console.WriteLine("Vetor - Exercicios Propostos 1");
        ExerProp01();
        break;

    case 5:
        Console.WriteLine("Vetor - Exercicios Propostos 2");
        ExerProp02();
        break;

    case 6:
        Console.WriteLine("Vetor - Exercicios Propostos 3");
        ExerProp03();
        break;
}





static void Exercicio01()
{
    int n;
    string entrada;
    int[] vet;


    n = int.Parse(Console.ReadLine());
    vet = new int[n];

    string[] s = Console.ReadLine().Split(' ');

    for (int i = 0; i < n; i++)
    {
        vet[i] = int.Parse(s[i]);
    }

    for (int i = 0; i < n; i++)
    {
        if (vet[i] < 0)
        {

            Console.WriteLine(vet[i]);
        }
    }

}


static void Exercicio02() {

    int n;
    double soma = 0.0, media = 0.0;
    double[] vet;
    string[] vetEntrada;

    n = int.Parse(Console.ReadLine());
    vet = new double[n];

    vetEntrada = Console.ReadLine().Split(' ');

    for (int i = 0; i < n; i++)
    {
        vet[i] = double.Parse(vetEntrada[i], CultureInfo.InvariantCulture);
        Console.Write(vet[i].ToString("F1" ,CultureInfo.InvariantCulture) + " ");
        soma += vet[i];
    }
    Console.WriteLine();

    media = soma / n;

    Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

}

static void Exercicio03() 
{
    int n, cont = 0;
    double alturaMedia = 0.0, porcentIdade;

    string[] nome;
    int[] idade;
    double[] altura;
    

    n = int.Parse(Console.ReadLine());
    nome = new string[n];
    idade = new int[n];
    altura = new double[n];

    for (int i = 0; i < n; i++)
    {
        string[] entrada;
        entrada = Console.ReadLine().Split(' ');
        nome [i] = entrada[0];
        idade[i] = int.Parse(entrada[1]);
        altura[i] = double.Parse(entrada[2], CultureInfo.InvariantCulture);
    }

    for (int i = 0; i < n; i++)
    {
        alturaMedia += altura[i];
    }

    alturaMedia /= n;
    Console.WriteLine("Altura média: " + alturaMedia.ToString("F2", CultureInfo.InvariantCulture));

    for (int i = 0; i < n; i++) 
    {
        if (idade[i] < 16) {
            cont++;
        }
    }

    porcentIdade = (double) cont / n * 100;
    Console.WriteLine("Pessoas com menos de 16 anos: " + porcentIdade.ToString("F1", CultureInfo.InvariantCulture));
}

static void ExerProp01() 
{

    int n;
    double maior = 0.0;
    string[] entrada;
    double[] numeros;

    n = int.Parse(Console.ReadLine());
    numeros = new double[n];
    entrada = new string[n];

    entrada = Console.ReadLine().Split(' ');


    for (int i = 0; i < n; i++) 
    {
        numeros[i] = double.Parse(entrada[i], CultureInfo.InvariantCulture);
    }

    for (int i = 0; i < n; i++) 
    {
        if (numeros[i] > maior) 
        {
            maior = numeros[i];
        
        }

    }

    Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));   
    

}

static void ExerProp02() 
{

    int n, cont = 0, div;
    string[] entrada;
    int[] numeros;
    int[] pares;
    
    n = int.Parse(Console.ReadLine());
    numeros = new int[n];   
    entrada = new string[n];  

    entrada = Console.ReadLine().Split(' ');

    for (int i = 0; i < n; i++) 
    {
        numeros[i] = int.Parse(entrada[i]);

        div = numeros[i] % 2;

        if (div == 0) 
        {
            Console.Write(numeros[i] + " ");
            cont++;
        }
    }
    Console.WriteLine();

    Console.WriteLine(cont);
}

static void ExerProp03()
{
    int n;
    double[] vetA;
    double[] vetB;
    double[] vetC;
    string[] entradaA;
    string[] entradaB;

    n = int.Parse(Console.ReadLine());
    vetA = new double[n];
    vetB = new double[n];
    vetC = new double[n];
    
    entradaA = Console.ReadLine().Split(' ');
    entradaB = Console.ReadLine().Split(' ');


    for (int i = 0; i < n; i++) 
    {
        vetA[i] = double.Parse(entradaA[i], CultureInfo.InvariantCulture);
        vetB[i] = double.Parse(entradaB[i], CultureInfo.InvariantCulture);

    }

    for (int i = 0; i < n; i++) 
    {
        vetC[i] = vetA[i] + vetB[i];

        Console.Write(vetC[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
    }
    Console.WriteLine();

}