// See https://aka.ms/new-console-template for more information
static void Memu() {
    Console.Clear();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine(" ");
    Console.WriteLine("S = Segundo");
    Console.WriteLine("M = Minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar?");
    Console.WriteLine(" "); 
    Console.WriteLine("-----------------------------------");
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
}

Memu();
