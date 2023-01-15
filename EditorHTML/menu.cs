using System;

namespace EditorHTML {
    public static class Menu {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen() {
            separateMenu();

            int columnsPipes = 11;
            for (int lines = 0; lines < columnsPipes; lines++) {
                Console.Write("|");

                int columnsSpaces = 40;
                for (int spaces = 0; spaces < columnsSpaces; spaces++) {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write('\n');
            }

            separateMenu();

            static void separateMenu() {
                Console.Write("+");
                int columnsHiphens = 40;
                for (int item = 0; item < columnsHiphens; item++)
                {
                    Console.Write("-");
                }
                Console.Write("+");

                Console.Write('\n');
            }
        }
        
        public static void WriteOptions() {
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma das opções abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir um arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("Opção: ");
        }
    
        public static void HandleMenuOption(short option) {
            switch (option) {
                case 1:
                    Console.WriteLine("Editor");
                    break;
                case 2:
                    Console.WriteLine("View");
                    break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default:
                    Show();
                    break;
            }
        }
    }
}
