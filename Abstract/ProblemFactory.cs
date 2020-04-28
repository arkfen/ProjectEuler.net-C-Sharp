using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.net_C_Sharp
{
    class ProblemFactory
    {
        public static IProblem Create(int problemNumber)
        {
            IProblem problem;
            switch (problemNumber)
            {
                case 1: 
                    problem = new Problem1();
                    break;
                case 2:
                    problem = new Problem2();
                    break;
                case 3:
                    problem = new Problem3();
                    break;
                case 4:
                    problem = new Problem4();
                    break;
                default:
                    return null;
            }
            return problem;
        }
    }
}
