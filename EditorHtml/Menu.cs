using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScree();
        }

        public static void DrawScree()
        {

            TopAndBottom();

            for(int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for(int cols = 0; cols <= 30; cols++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            TopAndBottom();
        }

        public static void TopAndBottom()
        {
            Console.Write("+");
            for(int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }
    }
}