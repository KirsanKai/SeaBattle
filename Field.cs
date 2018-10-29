using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Морской_Бой
{
    class Field
    {
        public char[,] field = new char[10, 10];

        public void fillField()
        {
            for (int i = 0; i < 10; i++) 
            {
                for (int j = 0; j < 10; j++)
                {
                    field[i, j] = '~';

                }
            }
        }

        public char getState(int x, int y)
        {
            return field[y, x];
        }
        public void setState(int x, int y, char state)
        {
            field[y, x] = state;
        }
        public char[,] getField()
        {
            return field;
        }

    }
}
