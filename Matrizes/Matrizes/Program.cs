Console.WriteLine("Exercicios Resolvidos: ");


Console.WriteLine("""
    1 - Matriz - Exercicio 1
    2 - Matriz - Exercicio 2

    """);
Console.Write("Escolha um Exercicio: ");
int entrada = int.Parse(Console.ReadLine());


switch (entrada)
{

    case 1:
        Console.WriteLine("Vetor - Exercicio 1");
        ExeMat01();
        break;

    case 2:
        Console.WriteLine("Vetor - Exercicio 2");
        ExeMat02();
        break;
}



static void ExeMat01() 
{
    int n, cont = 0;
    int[,] mat;

    n = int.Parse(Console.ReadLine());
    mat = new int[n,n];

    for (int i = 0; i < n; i++) 
    {
        string[] entrada = Console.ReadLine().Split(' ');

        for (int j = 0; j < n; j++) 
        {
            mat[i,j] = int.Parse(entrada[j]);

        }
    
    }

    Console.WriteLine("DIAGONAL PRICIPAL: ");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j)
            {
                Console.Write(mat[i, j] + " ");
            }
        }
    }
    Console.WriteLine();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++) 
        {
            if (mat[i, j] < 0) 
            {
                cont++;
            }
        }
    }

    Console.WriteLine("QUANTIDADE DE NEGATIVOS: " + cont);


}

static void ExeMat02() 
{
    int m, n, soma = 0;
    int[,] mat;
    int[] vetSoma;

    string[] tmMat = Console.ReadLine().Split(' ');
    m = int.Parse(tmMat[0]);
    n = int.Parse(tmMat[1]);

    vetSoma = new int[m];

    mat = new int[m, n];

    for (int i = 0; i < m; i++) 
    {
        string[] entrada = Console.ReadLine().Split(' ');

        for (int j = 0; j < n; j++) 
        {
            mat[i,j] = int.Parse(entrada[j] + " ");
        }
    }

    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++) 
        {
            soma += mat[i, j]; 
        }
        vetSoma[i] = soma;
        Console.WriteLine(vetSoma[i]);
        soma = 0;
    }

    


}