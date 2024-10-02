using System.Globalization;

Console.WriteLine("Exercicio URI Online Judge");
Console.WriteLine("Para acessar digite o numero do exercio ou 0 para SAIR.");

Console.WriteLine("MENU: \n" +
    """
     1 - URI 1001; 
     2 - URI 1002;
     3 - URI 1003; 
     4 - URI 1004;
     5 - URI 1005;
     6 - URI 1006;
     7 - URI 1007;
     8 - URI 1008;
     10 - URI 1010;
     14 - URI 1014

    """);

int entrada = int.Parse(Console.ReadLine());

switch (entrada)
{

    case 1:
        Console.WriteLine("Executando URI1001... \n" );
        URI1001();
        break;

    case 2:
        Console.WriteLine("Execuntado URI1002... \n");
        URI1002();
        break;

    case 3:
        Console.WriteLine("Execuntado URI1003... \n");
        URI1003();
        break;

    case 4:
        Console.WriteLine("Execuntado URI1004... \n");
        URI1004();
        break;

    case 5:
        Console.WriteLine("Execuntado URI1005... \n");
        URI1005();
        break;

    case 6:
        Console.WriteLine("Execuntado URI1006... \n");
        URI1006();
        break;

    case 7:
        Console.WriteLine("Execuntado URI1007... \n");
        URI1007();
        break;

    case 8:
        Console.WriteLine("Execuntado URI1008... \n");
        URI1008();
        break;

    case 10:
        Console.WriteLine("Execuntado URI1010... \n");
        URI1010();
        break;

    case 14:
        Console.WriteLine("Execuntado URI1014... \n");
        URI1014();
        break;


}




static void URI1001()
{

    Console.WriteLine("Bem vindo ao URI 1001");

    int A, B, X;

    Console.WriteLine("Digite um numero inteiro para A: ");
    A = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um numero inteiro para B: ");
    B = int.Parse(Console.ReadLine());

    X = A + B;
    Console.WriteLine("X = " + X); 

}

static void URI1002(){

    Console.WriteLine("Bem vindo ao URI 1002");

    double area, raio;
    double n = 3.14159;

    Console.WriteLine("Digite o valor do raio: ");
    raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    area = n * Math.Pow(raio, 2);

    Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));


}

static void URI1003() {

    Console.WriteLine("Bem vindo ao URI 1003");

    int a, b, soma;

    Console.WriteLine("Digite um valor para A: ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um valor para B: ");
    b = int.Parse(Console.ReadLine());

    soma = a + b;   
    Console.WriteLine("SOMA = " + soma);

}

static void URI1004() {

    Console.WriteLine("Bem vindo ao URI 1004");

    int a, b, prod;

    Console.WriteLine("Digite um valor para A: ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um valor para B: ");
    b = int.Parse(Console.ReadLine());

    prod = a * b;
    Console.WriteLine("PROD = " + prod);

}

static void URI1005()
{

    Console.WriteLine("Bem vindo ao URI 1005");

    double notaA, notaB, media;
    double pesoA = 3.5, pesoB = 7.5, somaPesos;

    Console.WriteLine("Digite o valor da nota A:");
    notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Digite o valor da nota B:");
    notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    somaPesos = pesoA + pesoB;

    media = ((notaA * pesoA) + (notaB * pesoB)) / somaPesos ;

    Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));



}

static void URI1006()
{

    Console.WriteLine("Bem vindo ao URI 1006");

    double notaA, notaB, notaC, media;
    double pesoA = 2, pesoB = 3, pesoC = 5, somaPesos;

    Console.WriteLine("Digite o valor da nota A:");
    notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Digite o valor da nota B:");
    notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Digite o valor da nota C:");
    notaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


    somaPesos = pesoA + pesoB + pesoC;

    media = ((notaA * pesoA) + (notaB * pesoB) + (notaC * pesoC)) / somaPesos;

    Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));

}



static void URI1007()
{

    Console.WriteLine("Bem vindo ao URI 1007");

    int a, b, c, d, dif;

    Console.WriteLine("Digite um valor para A: ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um valor para B: ");
    b = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um valor para C: ");
    c = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um valor para D: ");
    d = int.Parse(Console.ReadLine());

    dif = (a * b) - (c * d);
    Console.WriteLine("DIFERENCA = " + dif);

}

static void URI1008()
{

    Console.WriteLine("Bem vindo ao URI 1008");

    int numero, horas;
    double valor, salario;

    Console.WriteLine("Digite o numero do funcionario: ");
    numero = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite as horas trabalhadas: ");
    horas = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor da horas: ");
    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    salario = valor * horas;

    Console.WriteLine("NUMBER = " + numero);
    Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
}


static void URI1010()
{

    Console.WriteLine("Bem vindo ao URI 1010");

    int cod1, cod2, qtde1, qtde2;
    double valor1, valor2, total;

    Console.WriteLine("Insira o CODIGO, QUANTIDADE e VALOR: ");
    string[] valores = Console.ReadLine().Split(' ');
    cod1 = int.Parse(valores[0]);
    qtde1 = int.Parse(valores[1]);
    valor1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

    Console.WriteLine("Insira o CODIGO, QUANTIDADE e VALOR: ");
    valores = Console.ReadLine().Split(' ');
    cod2 = int.Parse(valores[0]);
    qtde2 = int.Parse(valores[1]);
    valor2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

    total = valor1 * qtde1 + valor2 * qtde2;

    Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

}


static void URI1014()
{

    Console.WriteLine("Bem vindo ao URI 1014");

    int km;
    double gas, total;

    Console.WriteLine("Km percorrido: ");
    km = int.Parse(Console.ReadLine());
    Console.WriteLine("Combustivel: ");
    gas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    total = km / gas;

    Console.WriteLine(total.ToString("F3", CultureInfo.InvariantCulture) + " km/l");


}



