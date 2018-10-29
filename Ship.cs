using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Морской_Бой
{
    class Ship
    {
        public string name;
        public int size;
        public int count;

        public Ship(string name, int size, int count)
        {
            this.name = name;
            this.size = size;
            this.count = count;
        }

        public int getSize()
        {
            return size;
        }
        public int getCount()
        {
            return count;
        }
        public void changeCount(int a)
        {
            count = count + a;
        }
    }
}
