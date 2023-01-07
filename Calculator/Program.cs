// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Beep(5000, 1000);
Menu();

static float PrimeiroValor() {
    float valor1 = 0;

    Console.WriteLine("Digite o primeiro valor: ");
    string? valor = Console.ReadLine();

    if (valor == null || valor == "") {
        PrimeiroValor();
    } else {
        valor1 = float.Parse(valor);
        Console.WriteLine(" ");
    }

    return valor1;
}

static float SegundoValor() {
    float valor2 = 0;

    Console.WriteLine("Digite o segundo valor: ");
    string? valor = Console.ReadLine();

    if (valor == null || valor == "") {
        SegundoValor();
    } else {
        valor2 = float.Parse(valor);
        Console.WriteLine(" ");
    }

    return valor2;
}

static void ResultadoOperacao(float resultado) {
    Console.WriteLine(" ");
    Console.WriteLine($"O resultado da divisão é: {resultado}");
}

static void RetornarAoMenu() {
    Console.WriteLine(" ");
    Console.WriteLine("Pressione alguma tecla para voltar ao menu.");
    Console.ReadKey();
    Menu();
}

static void Menu() {
    Console.Clear();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine(" ");
    Console.WriteLine("Escolha uma das opções abaixo: ");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");
    Console.WriteLine(" ");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine(" ");
    
    string? valor = Console.ReadLine();

    if (valor == null || valor == "") {
        Menu();
    } else {
        short? resposta = short.Parse(valor);

        switch (resposta) {
            case 1:
                float resultado = Soma(PrimeiroValor(), SegundoValor());
                ResultadoOperacao(resultado);
                RetornarAoMenu();
                break;
            case 2:
                resultado = Subtracao(PrimeiroValor(), SegundoValor());
                ResultadoOperacao(resultado);
                RetornarAoMenu();
                break;
            case 3:
                resultado = Multiplicacao(PrimeiroValor(), SegundoValor());
                ResultadoOperacao(resultado);
                RetornarAoMenu();
                break;
            case 4:
                resultado = Divisao(PrimeiroValor(), SegundoValor());
                ResultadoOperacao(resultado);
                RetornarAoMenu();
                break;
            case 5:
                Environment.Exit(0);
                break;
            default:
                Menu();
                break;
        }
    }
}

static float Soma(float valor1, float valor2) {
    float resultado = valor1 + valor2;
    return resultado;
}

static float Subtracao(float valor1, float valor2) {
    float resultado = valor1 - valor2;
    return resultado;
}

static float Multiplicacao(float valor1, float valor2) {
    float resultado = valor1 / valor2;
    return resultado;
}

static float Divisao(float valor1, float valor2) {
    float resultado = valor1 / valor2;
    return resultado;
}
