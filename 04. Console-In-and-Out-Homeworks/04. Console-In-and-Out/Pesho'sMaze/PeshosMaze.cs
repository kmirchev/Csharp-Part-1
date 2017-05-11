namespace PeshosMaze
{
    using System;
    using System.Diagnostics;


    class Program
    {
        static void Main()
        {
            //  constants & configuration
            const char wallSymbol = '█';
            const char player = '☻';
            const char coin = '©';

            const int escapeX = 19;
            const int escapeY = 1;

            //const int consoleWidth = 21;
            //const int consoleHeight = 11;

            const ConsoleColor defaultBackgroundColor = ConsoleColor.White;
            const ConsoleColor defaultforegroundColor = ConsoleColor.Black;
            const ConsoleColor playerColor = ConsoleColor.DarkGreen;

            // console prep
            Console.BackgroundColor = defaultBackgroundColor;
            Console.Clear();

            //Console.WindowHeight = consoleHeight;
            //Console.BufferHeight = consoleHeight;

            //Console.WindowWidth = consoleWidth;
            //Console.BufferWidth = consoleWidth;

            //Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;

            // setup the date
            string[] maze = new string[10]
            {
                "████████████████████",
                "█           ©       ",
                "█  █████████████████",
                "█  ███           ███",
                "█    ©  ██████   ███",
                "██████████████   ███",
                "█  ©       ███   ███",
                "████████   ███   ███",
                "█ ©             ████",
                "████████████████████"
            };


            int playerX = 1;
            int playerY = 8;
            int coinsCollected = 0;

            Stopwatch timer = new Stopwatch();
            timer.Start();

            while (playerX != escapeX || playerY != escapeY)
            {
                // check if coin
                if (maze[playerY][playerX] == coin)
                {
                    coinsCollected++;
                    maze[playerY] = maze[playerY].Replace(coin, ' ');
                }
                //  print the maze
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = defaultforegroundColor;
                Console.Write(string.Join(Environment.NewLine, maze));

                //  print the player
                Console.SetCursorPosition(playerX, playerY);
                Console.ForegroundColor = playerColor;
                Console.Write(player);

                // read user input
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                // move if there is not a wall in our way
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:

                        if (maze[playerY - 1][playerX] != wallSymbol)

                        {
                            playerY--;
                        }

                        break;
                    case ConsoleKey.DownArrow:

                        if (maze[playerY + 1][playerX] != wallSymbol)

                        {
                            playerY++;
                        }

                        break;
                    case ConsoleKey.RightArrow:

                        if (maze[playerY][playerX + 1] != wallSymbol)

                        {
                            playerX++;
                        }

                        break;
                    case ConsoleKey.LeftArrow:

                        if (maze[playerY][playerX - 1] != wallSymbol)

                        {
                            playerX--;
                        }

                        break;
                    default:
                        break;
                }
               
            }
            timer.Stop();
            string message = timer.Elapsed.Seconds <= 20 ? "You beat the clock!" : "Be faster next time!";
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(message);
            Console.WriteLine("You got in {0} seconds, {2} {1} coins collected", timer.Elapsed.Seconds, coinsCollected, Environment.NewLine);
        }
    }
}
