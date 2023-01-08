// See https://aka.ms/new-console-template for more information
static void Menu() {
    Console.Clear();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine(" ");
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("1 - Abrir arquivo");
    Console.WriteLine("2 - Criar um novo arquivo");
    Console.WriteLine(" ");
    Console.WriteLine("-----------------------------------");

    short? option = short.Parse(Console.ReadLine());

    switch (option) {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            open();
            break;
        case 2:
            Edit();
            break;
        default:
            Menu();
            break;
    }

}

static void open() {
    Console.Clear();
    Console.WriteLine("Digite o caminho do arquivo: ");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine(" ");

    string path = Console.ReadLine();

    using (var file = new StreamReader(path)) {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
    }

    Console.WriteLine(" ");
    Console.ReadLine();
    Menu();
}

static void Edit() {
    Console.Clear();
    Console.WriteLine("Pressione ESC para sair.");
    Console.WriteLine("Digite seu texto: ");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine(" ");

    string? text = "";

    do {
        text += Console.ReadLine();
        text += Environment.NewLine;
    } while (Console.ReadKey().Key != ConsoleKey.Escape);

    Save(text);
}

static void Save(string text) {
    Console.Clear();
    Console.WriteLine("Digite o caminho de salvamento do arquivo: ");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine(" ");

    var path = Console.ReadLine();
    using (var file = new StreamWriter(path)) {
        file.Write(text);
    }

    Console.WriteLine(" "); 
    Console.WriteLine("-----------------------------------");    
    Console.WriteLine($"Arquivo {path} salvo com sucesso.");
    Console.ReadLine();
    Menu();
}

Menu();
