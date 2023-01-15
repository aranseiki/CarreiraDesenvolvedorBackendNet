using System;

namespace EditorHTML {
    public static class Menu {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
        }

        public static void DrawScreen() {
            separateMenu();

            int columnsPipes = 10;
            for (int lines = 0; lines < columnsPipes; lines++) {
                Console.Write("|");

                int columnsSpaces = 30;
                for (int spaces = 0; spaces < columnsSpaces; spaces++) {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write('\n');
            }

            separateMenu();
        }

        public static void separateMenu() {
            Console.Write("+");
            int columnsHiphens = 30;
            for (int item = 0; item < columnsHiphens; item++) {
                Console.Write("-");
            }
            Console.Write("+");

            Console.Write('\n');
        }
    }
}
