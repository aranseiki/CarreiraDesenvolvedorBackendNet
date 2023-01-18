using System;
using System.Text.RegularExpressions;

namespace EditorHTML { 
	public class Viewer {
		public static void Show(string text) {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("MODO DE VISUALIZAÇÂO");
            Console.WriteLine("==================");
            Replace(text);
            Console.WriteLine("==================");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text) {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');
            for (int item = 0; item < words.Length; item++) {
                if (strong.IsMatch(words[item])) {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(words[item].Substring(
                        words[item].IndexOf('>') + 1,
                            (words[item].LastIndexOf('<') - 1) - words[item].IndexOf('>')
                        )
                    );
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(' ');
                } else {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(words[item]);
                    Console.WriteLine(' ');
                }
            }            
        }
	}
}
