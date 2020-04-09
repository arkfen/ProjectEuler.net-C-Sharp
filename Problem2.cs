using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.net_C_Sharp
{
    class Problem2
    {
        private const int _limit = 4000000;

        private int _fiboFather = 2;
        private int _fiboGrandpa = 1;
        
        public int GetResult()
        {
            int fiboSon = _fiboFather;
            int sum = 0;
            while(fiboSon <= _limit)
            {
                if(fiboSon % 2 == 0)
                {
                    sum += fiboSon;
                }
                fiboSon = GetFiboSon();
                ShiftFiboGeneration(fiboSon);
            }
            return sum;
        }

        private int GetFiboSon()
        {
            return _fiboGrandpa + _fiboFather;
        }

        private void ShiftFiboGeneration(int fiboSon)
        {
            _fiboGrandpa = _fiboFather;
            _fiboFather = fiboSon;
        }
    }
}
