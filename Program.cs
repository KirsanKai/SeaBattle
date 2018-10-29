using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Морской_Бой
{
    class Program
    {
        static void Main(string[] args)
        {
            int mode;
            Menu Menu = new Menu();
            Console.WindowWidth = 170;
            Console.BufferWidth = 240;
            Console.BufferHeight = 63;

            mode = Menu.modeSelect();
            if (mode == 1)
            {
                Console.Clear();
            }
            else if (mode == 2)
            {
                Console.Clear();

                Player Player1 = new Player();
                Player Player2 = new Player();
                Fleet Fleet1 = new Fleet();
                Fleet Fleet2 = new Fleet();

                Player1.playerInitialization();
                Player2.playerInitialization();

                Menu.createMartup();
                Menu.createFieldsPlayer(Player1.getMyField(), Player1.getEnemyField(), 1);
                Menu.placeShips(1);
                Menu.readXY(1);
                while (Fleet1.getShipCount("Battleship") > 0)
                {
                    bool ok = Player1.placeShip(char.Parse(Menu.toRead(34, 38)), int.Parse(Menu.toRead(38, 38)), int.Parse(Menu.toRead(44, 38)), Fleet1.getShipSize("Battleship"));
                    if (ok == true)
                    {
                        Menu.createFieldsPlayer(Player1.getMyField(), Player1.getEnemyField(), 1);
                        Fleet1.changeShipCount("Battleship", -1);
                    }
                    Menu.readXY(1);
                }/*
                Console.SetCursorPosition(27, 30); Console.Write("ГОТОВО!");
                while (Fleet1.getShipCount("Cruiser") > 0)
                {
                    bool ok = Player1.placeShip(char.Parse(Menu.toRead(34, 38)), int.Parse(Menu.toRead(38, 38)), int.Parse(Menu.toRead(44, 38)), Fleet1.getShipSize("Cruiser"));
                    if (ok == true)
                    {
                        Menu.createFieldsPlayer(Player1.getMyField(), Player1.getEnemyField(), 1);
                        Fleet1.changeShipCount("Cruiser", -1);
                    }
                    Menu.readXY(1);
                }
                Console.SetCursorPosition(28, 32); Console.Write("ГОТОВО!");
                while (Fleet1.getShipCount("Destroyer") > 0)
                {
                    bool ok = Player1.placeShip(char.Parse(Menu.toRead(34, 38)), int.Parse(Menu.toRead(38, 38)), int.Parse(Menu.toRead(44, 38)), Fleet1.getShipSize("Destroyer"));
                    if (ok == true)
                    {
                        Menu.createFieldsPlayer(Player1.getMyField(), Player1.getEnemyField(), 1);
                        Fleet1.changeShipCount("Destroyer", -1);
                    }
                    Menu.readXY(1);
                }
                Console.SetCursorPosition(27, 34); Console.Write("ГОТОВО!");
                while (Fleet1.getShipCount("Boat") > 0)
                {
                    bool ok = Player1.placeShip(char.Parse(Menu.toRead(34, 38)), int.Parse(Menu.toRead(38, 38)), int.Parse(Menu.toRead(44, 38)), Fleet1.getShipSize("Boat"));
                    if (ok == true)
                    {
                        Menu.createFieldsPlayer(Player1.getMyField(), Player1.getEnemyField(), 1);
                        Fleet1.changeShipCount("Boat", -1);
                    }
                    Menu.readXY(1);
                }*/
                Console.SetCursorPosition(29, 36); Console.Write("ГОТОВО!");
                Console.SetCursorPosition(3, 40); Console.Write("ОЖИДАНИЕ ПЕРЕДАЧИ ХОДА!");
                Console.ReadKey();
                Console.Clear();

                Menu.createMartup();
                Menu.createFieldsPlayer(Player2.getMyField(), Player2.getEnemyField(), 2);
                Menu.placeShips(2);
                Menu.readXY(2);
                while (Fleet2.getShipCount("Battleship") > 0)
                {
                    bool ok = Player2.placeShip(char.Parse(Menu.toRead(154, 38)), int.Parse(Menu.toRead(158, 38)), int.Parse(Menu.toRead(164, 38)), Fleet2.getShipSize("Battleship"));
                    if (ok == true)
                    {
                        Menu.createFieldsPlayer(Player2.getMyField(), Player2.getEnemyField(), 2);
                        Fleet2.changeShipCount("Battleship", -1);
                    }
                    Menu.readXY(2);
                }/*
                Console.SetCursorPosition(147, 30); Console.Write("ГОТОВО!");
                while (Fleet2.getShipCount("Cruiser") > 0)
                {
                    bool ok = Player2.placeShip(char.Parse(Menu.toRead(154, 38)), int.Parse(Menu.toRead(158, 38)), int.Parse(Menu.toRead(164, 38)), Fleet2.getShipSize("Cruiser"));
                    if (ok == true)
                    {
                        Menu.createFieldsPlayer(Player2.getMyField(), Player2.getEnemyField(), 2);
                        Fleet2.changeShipCount("Cruiser", -1);
                    }
                    Menu.readXY(2);
                }
                Console.SetCursorPosition(148, 32); Console.Write("ГОТОВО!");
                while (Fleet1.getShipCount("Destroyer") > 0)
                {
                    bool ok = Player2.placeShip(char.Parse(Menu.toRead(154, 38)), int.Parse(Menu.toRead(158, 38)), int.Parse(Menu.toRead(164, 38)), Fleet2.getShipSize("Destroyer"));
                    if (ok == true)
                    {
                        Menu.createFieldsPlayer(Player2.getMyField(), Player2.getEnemyField(), 1);
                        Fleet2.changeShipCount("Destroyer", -1);
                    }
                    Menu.readXY(2);
                }
                Console.SetCursorPosition(147, 34); Console.Write("ГОТОВО!");
                while (Fleet2.getShipCount("Boat") > 0)
                {
                    bool ok = Player2.placeShip(char.Parse(Menu.toRead(154, 38)), int.Parse(Menu.toRead(158, 38)), int.Parse(Menu.toRead(164, 38)), Fleet2.getShipSize("Boat"));
                    if (ok == true)
                    {
                        Menu.createFieldsPlayer(Player2.getMyField(), Player2.getEnemyField(), 2);
                        Fleet2.changeShipCount("Boat", -1);
                    }
                    Menu.readXY(2);
                }*/
                Console.SetCursorPosition(149, 36); Console.Write("ГОТОВО!");
                Console.SetCursorPosition(123, 40); Console.Write("ОЖИДАНИЕ ПЕРЕХОДА К АКТИВНОЙ ФАЗЕ!");
                Console.ReadKey();
                Console.Clear();
                while (Player1.getIsWin() != true || Player2.getIsWin() != true)
                {
                    Menu.createMartup();
                    Console.SetCursorPosition(123, 30); Console.Write("ХОД ПЕРВОГО ИГРОКА!");
                    Console.SetCursorPosition(3, 30); Console.Write("ХОД ПЕРВОГО ИГРОКА!");
                    Console.ReadKey();
                    Console.SetCursorPosition(123, 30); Console.Write("                        ");
                    Console.SetCursorPosition(3, 30); Console.Write("                         ");
                    bool okStrike = true;
                    while (okStrike == true && Player1.getIsWin() != true)
                    {
                        Menu.createFieldsPlayer(Player1.getMyField(), Player1.getEnemyField(), 1);
                        Console.SetCursorPosition(3, 32); Console.Write("Куда прикажете стрелять, адмирал?");
                        Console.SetCursorPosition(3, 34); Console.Write("X:   , Y: ");
                        okStrike = Player1.strike(int.Parse(Menu.toRead(6, 34)), int.Parse(Menu.toRead(13, 34)), Player2.getMyField());
                        Console.SetCursorPosition(3, 34); Console.Write("                                  ");
                    } 
                    if (Player1.getIsWin() == true) 
                    { 
                        Console.SetCursorPosition(3, 36); 
                        Console.Write("Адмирал, мы победили!"); 
                        Console.ReadKey(); 
                        break; 
                    }
                    Menu.createFieldsPlayer(Player1.getMyField(), Player1.getEnemyField(), 1);
                    Console.SetCursorPosition(3, 36); Console.Write("Сэр, мы промазали, теперь враг стреляет по нам. ДЕРЖИТЕСЬ!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu.createMartup();
                    Console.SetCursorPosition(3, 30); Console.Write("ХОД ВТОРОГО ИГРОКА!");
                    Console.SetCursorPosition(123, 30); Console.Write("ХОД ВТОРОГО ИГРОКА!");
                    Console.ReadKey();
                    Console.SetCursorPosition(3, 30); Console.Write("                         ");
                    Console.SetCursorPosition(123, 30); Console.Write("                          ");
                    okStrike = true;
                    while (okStrike == true && Player2.getIsWin() != true)
                    {
                        Menu.createFieldsPlayer(Player2.getMyField(), Player2.getEnemyField(), 2);
                        Console.SetCursorPosition(123, 32); Console.Write("Куда прикажете стрелять, адмирал?");
                        Console.SetCursorPosition(123, 34); Console.Write("X:   , Y: ");
                        okStrike = Player2.strike(int.Parse(Menu.toRead(126, 34)), int.Parse(Menu.toRead(133, 34)), Player1.getMyField());
                        Console.SetCursorPosition(123, 34); Console.Write("                                    ");
                    } 
                    if (Player2.getIsWin() == true) 
                    { 
                        Console.SetCursorPosition(123, 36); 
                        Console.Write("Адмирал, мы победили!"); 
                        Console.ReadKey(); 
                        break; 
                    }
                    Console.SetCursorPosition(123, 36); Console.Write("Сэр, мы промазали, теперь враг стреляет по нам. ДЕРЖИТЕСЬ!");
                    Menu.createFieldsPlayer(Player2.getMyField(), Player2.getEnemyField(), 2);
                    Console.ReadKey();
                    Console.Clear();
                }
                
            }
            //Menu.createMartup();
            //Menu.createFieldsPlayer1(Player1.getMyField(), Player1.getEnemyField());
            //Menu.createFieldsPlayer2(Player2.getMyField(), Player2.getEnemyField());
           


        }
    }
}
