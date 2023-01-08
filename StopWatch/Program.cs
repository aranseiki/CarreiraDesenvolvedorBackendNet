// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

static void Menu() {
    Console.Clear();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine(" ");
    Console.WriteLine("S = Segundo");
    Console.WriteLine("M = Minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Ex.: ");    
    Console.WriteLine("     10s = 10 segundos");
    Console.WriteLine("     1m = 1 minuto");
    Console.WriteLine("Quanto tempo deseja contar?");
    Console.WriteLine(" ");
    Console.WriteLine("-----------------------------------");

    string? data = Console.ReadLine().ToLower();
    if (data == "" || data == "0") {
        Environment.Exit(0);
    }
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1;

    if (time == 0) {
        Environment.Exit(0);
    }

    if (type == 'm') {
        multiplier = 60;
    }

    Start(time * multiplier);
}

static void Start(int time) {
    int currentTime = 0;
	while (currentTime != time) {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Stopwatch finalizado.");
    Thread.Sleep(2500);
    Menu();
}

Menu();
