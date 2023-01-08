// See https://aka.ms/new-console-template for more information
Console.Clear();
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

static void ResultadoOperacao(string operacao, float resultado) {
    Console.WriteLine(" ");
    Console.WriteLine($"O resultado da {operacao} é: {resultado}");
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
        string operacao = "";
        float resultado = 0;

        switch (resposta) {
            case 1:
                operacao = "soma";
                resultado = Soma(PrimeiroValor(), SegundoValor());                
                break;
            case 2:
                operacao = "subtração";
                resultado = Subtracao(PrimeiroValor(), SegundoValor());
                break;
            case 3:
                operacao = "multiplicação";
                resultado = Multiplicacao(PrimeiroValor(), SegundoValor());
                break;
            case 4:
                operacao = "divisão";
                resultado = Divisao(PrimeiroValor(), SegundoValor());
                break;
            case 5:
                Environment.Exit(0);
                break;
            default:
                Menu();
                break;
        }

        ResultadoOperacao(operacao, resultado);
        RetornarAoMenu();
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
