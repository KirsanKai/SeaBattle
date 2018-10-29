using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Морской_Бой
{
    class Player
    {
        public int shipCount;
        public Boolean isWin;
        public Boolean isTurn;
        Field myField = new Field();
        Field enemyField = new Field();

        public void playerInitialization()
        {
            shipCount = 4;
            isWin = false;
            isTurn = false;
            myField.fillField();
            enemyField.fillField();
        }
        public bool placeShip(char line, int x, int y, int size)
        {
            switch (line)
            {
                case 'h':
                    if (x + size <= 10 && y <= 10)
                    {
                        for (int i = x; i < x + size; i++)
                        {
                            if (myField.field[i - 1, y - 1] != 'H')
                            {
                                myField.field[i - 1, y - 1] = 'H';
                            }
                            else if (myField.field[i - 1, y - 1] == 'H')
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                    break;
                case 'v':
                    if (y + size <= 10 && x <= 10)
                    {
                        for (int i = y; i < y + size; i++)
                        {
                            if (myField.field[x - 1, i - 1] != 'H')
                            {
                                myField.field[x - 1, i - 1] = 'H';
                            }
                            else if (myField.field[x - 1, i - 1] == 'H')
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                    break;
            }
            return false;
        }
        public bool strike(int x, int y, char[,] enemyField)
        {
            if (shipCount == 0) 
            { 
                return false; 
            }
            else
            {
                if (enemyField[x - 1, y - 1] == 'H')
                {
                    enemyField[x - 1, y - 1] = 'X';
                    this.enemyField.field[x - 1, y - 1] = 'X';
                    shipCount--;
                    checkWin();
                    return true;
                }
                if (enemyField[x - 1, y - 1] == 'X' || enemyField[x - 1, y - 1] == 'O')
                {
                    return true;
                }
                if (enemyField[x - 1, y - 1] == '~')
                {
                    enemyField[x - 1, y - 1] = 'O';
                    this.enemyField.field[x - 1, y - 1] = 'O';
                    return false;
                }
                return false;
            }
        }
        public void checkTurn()
        {
            if (isTurn == false)
            {
                isTurn = true;
            }
            else
            {
                isTurn = false;
            }
        }
        public void checkWin() {
            if (shipCount == 0)
            {
                isWin = true;
            }
        }

        public bool getIsWin()
        {
            return isWin;
        }
        public char getStateMyField(int x, int y) 
        {
            return myField.getState(x, y);
        }
        public char getStateEnemyField(int x, int y)
        {
            return myField.getState(x, y);
        }
        public char[,] getMyField()
        {
            return myField.getField();
        }
        public char[,] getEnemyField()
        {
            return enemyField.getField();
        }
    }
}
