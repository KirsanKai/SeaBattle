using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Морской_Бой
{
    class Menu
    {
        public void createMartup()
        {
            for (int i = 0; i < 239; i++)
            {
                Console.SetCursorPosition(i, 29); Console.Write('_');
            }

            for (int i = 0; i < 63; i++)
            {
                Console.SetCursorPosition(0, i); Console.Write('|');
                Console.SetCursorPosition(239, i); Console.Write('|');

                Console.SetCursorPosition(120, i); Console.Write('|');
                Console.SetCursorPosition(119, i); Console.Write('|');
            }

            for (int i = 2; i < 28; i++)
            {
                Console.SetCursorPosition(60, i); Console.Write('|');
                Console.SetCursorPosition(59, i); Console.Write('|');

                Console.SetCursorPosition(180, i); Console.Write('|');
                Console.SetCursorPosition(179, i); Console.Write('|');

            }
        }
        public void createFieldsPlayer(char[,] myField, char[,] enemyField, int who)
        {
            switch (who)
            {
                case 1:
                    Console.SetCursorPosition(8, 3); Console.Write("Твое поле:");
                    Console.SetCursorPosition(68, 3); Console.Write("Вражеское поле:");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.SetCursorPosition(12 + 4 * i, 5); Console.Write(i + 1);
                        Console.SetCursorPosition(8, 7 + 2 * i); Console.Write(i + 1);
                        Console.SetCursorPosition(72 + 4 * i, 5); Console.Write(i + 1);
                        Console.SetCursorPosition(68, 7 + 2 * i); Console.Write(i + 1);
                        for (int j = 0; j < 10; j++)
                        {
                            Console.SetCursorPosition(12 + 4 * j, 7 + 2 * i); Console.Write(myField[j, i]);
                            Console.SetCursorPosition(72 + 4 * j, 7 + 2 * i); Console.Write(enemyField[j, i]);
                        }
                    }
                    break;
                case 2:
                    Console.SetCursorPosition(128, 3); Console.Write("Твое поле:");
                    Console.SetCursorPosition(188, 3); Console.Write("Вражеское поле:");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.SetCursorPosition(132 + 4 * i, 5); Console.Write(i + 1);
                        Console.SetCursorPosition(128, 7 + 2 * i); Console.Write(i + 1);
                        Console.SetCursorPosition(192 + 4 * i, 5); Console.Write(i + 1);
                        Console.SetCursorPosition(188, 7 + 2 * i); Console.Write(i + 1);
                        for (int j = 0; j < 10; j++)
                        {
                            Console.SetCursorPosition(132 + 4 * j, 7 + 2 * i); Console.Write(myField[j, i]);
                            Console.SetCursorPosition(192 + 4 * j, 7 + 2 * i); Console.Write(enemyField[j, i]);
                        }
                    }
                    break;
            }
        }

        public void clearFieldsPlayer(int who)
        {
            switch (who)
            {
                case 1:
                    Console.SetCursorPosition(8, 3); Console.Write("                  ");
                    Console.SetCursorPosition(68, 3); Console.Write("                 ");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.SetCursorPosition(12 + 4 * i, 5); Console.Write("  ");
                        Console.SetCursorPosition(8, 7 + 2 * i); Console.Write("  ");
                        Console.SetCursorPosition(72 + 4 * i, 5); Console.Write("  ");
                        Console.SetCursorPosition(68, 7 + 2 * i); Console.Write("  ");
                        for (int j = 0; j < 10; j++)
                        {
                            Console.SetCursorPosition(12 + 4 * j, 7 + 2 * i); Console.Write("  ");
                            Console.SetCursorPosition(72 + 4 * j, 7 + 2 * i); Console.Write("  ");
                        }
                    }
                    break;
                case 2:
                    Console.SetCursorPosition(128, 3); Console.Write("                ");
                    Console.SetCursorPosition(188, 3); Console.Write("                ");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.SetCursorPosition(132 + 4 * i, 5); Console.Write("  ");
                        Console.SetCursorPosition(128, 7 + 2 * i); Console.Write("  ");
                        Console.SetCursorPosition(192 + 4 * i, 5); Console.Write("  ");
                        Console.SetCursorPosition(188, 7 + 2 * i); Console.Write("  ");
                        for (int j = 0; j < 10; j++)
                        {
                            Console.SetCursorPosition(132 + 4 * j, 7 + 2 * i); Console.Write("  ");
                            Console.SetCursorPosition(192 + 4 * j, 7 + 2 * i); Console.Write("  ");
                        }
                    }
                    break;
            }
        }

        public void createFieldsPlayer(char[,] myField, char[,] enemyField)
        {
            Console.SetCursorPosition(128, 3); Console.Write("Твое поле:");
            Console.SetCursorPosition(188, 3); Console.Write("Вражеское поле:");
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(132 + 4 * i, 5); Console.Write(i + 1);
                Console.SetCursorPosition(128, 7 + 2 * i); Console.Write(i + 1);
                Console.SetCursorPosition(192 + 4 * i, 5); Console.Write(i + 1);
                Console.SetCursorPosition(188, 7 + 2 * i); Console.Write(i + 1);
                for (int j = 0; j < 10; j++)
                {
                    Console.SetCursorPosition(132 + 4 * j, 7 + 2 * i); Console.Write(myField[j, i]);
                    Console.SetCursorPosition(192 + 4 * j, 7 + 2 * i); Console.Write(myField[j, i]);
                }
            }
        }
        public int modeSelect()
        {
            Console.SetCursorPosition(109, 20); Console.Write("Выберите режим игры:");
            Console.SetCursorPosition(109, 22); Console.Write("1. Игрок против компьютера");
            Console.SetCursorPosition(109, 23); Console.Write("2. Игрок против игрока");
            Console.SetCursorPosition(130, 20);
            var a = int.Parse(Console.ReadLine());
            return a;
        }
        public string toRead(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            return Console.ReadLine();
        }
        public void placeShips(int who)
        {
            switch (who)
            {
                case 1:
                    Console.SetCursorPosition(3, 30); Console.Write("Разместите один линкор:");
                    Console.SetCursorPosition(3, 32); Console.Write("Разместите два крейсера:");
                    Console.SetCursorPosition(3, 34); Console.Write("Разместите три эсминца:");
                    Console.SetCursorPosition(3, 36); Console.Write("Разместите четыре катера:");
                    break;
                case 2:
                    Console.SetCursorPosition(123, 30); Console.Write("Разместите один линкор:");
                    Console.SetCursorPosition(123, 32); Console.Write("Разместите два крейсера:");
                    Console.SetCursorPosition(123, 34); Console.Write("Разместите три эсминца:");
                    Console.SetCursorPosition(123, 36); Console.Write("Разместите четыре катера:");
                    break;
            }
        }
        public void readXY(int who)
        {
            switch (who)
            {
                case 1:
                    Console.SetCursorPosition(3, 38); Console.Write("Координаты корабля: ориентация:  x:  , y: ");
                    break;
                case 2:
                    Console.SetCursorPosition(123, 38); Console.Write("Координаты корабля: ориентация:  x:  , y: ");
                    break;
            }
        }
        public void readyShip()
        {

        }
    }
}
