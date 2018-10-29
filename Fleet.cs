using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Морской_Бой
{
    class Fleet
    {
        Ship Battleship = new Ship("Battleship", 4, 1);
        Ship Cruiser = new Ship("Cruiser", 3, 2);
        Ship Destroyer = new Ship("Destroyer", 2, 3);
        Ship Boat = new Ship("Boat", 1, 4);

        public int getShipCount(string name) 
        {
            switch (name) 
            {   
                case "Battleship":
                    return Battleship.getCount();
                case "Cruiser":
                    return Cruiser.getCount();
                case "Destroyer":
                    return Destroyer.getCount();
                case "Boat":
                    return Boat.getCount();
            }
            return 0;
        }
        public int getShipSize(string name)
        {
            switch (name)
            {
                case "Battleship":
                    return Battleship.getSize();
                case "Cruiser":
                    return Cruiser.getSize();
                case "Destroyer":
                    return Destroyer.getSize();
                case "Boat":
                    return Boat.getSize();
            }
            return 0;
        }
        public void changeShipCount(string name, int a)
        {
            switch (name)
            {
                case "Battleship":
                    Battleship.changeCount(a);
                    break;
                case "Cruiser":
                    Cruiser.changeCount(a);
                    break;
                case "Destroyer":
                    Destroyer.changeCount(a);
                    break;
                case "Boat":
                    Boat.changeCount(a);
                    break;
            }
        }


    }
}
