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

}

static void Edit() {
    Console.Clear();
    Console.WriteLine("Pressione ESC para sair.");
    Console.WriteLine("Digite seu texto: ");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine(" ");

    string text = "";

    do {
        text += Console.ReadLine();
        text += Environment.NewLine;
    } while (Console.ReadKey().Key != ConsoleKey.Escape);

    Console.Write(text);
}

Menu();