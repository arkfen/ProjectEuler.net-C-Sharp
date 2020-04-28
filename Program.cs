using System;

namespace ProjectEuler.net_C_Sharp
{
    class Program
    {
        private const int _problemNumber = 4; // Set the value according to the problem number from https://projecteuler.net/archives

        static void Main(string[] args)
        {
            IProblem problem = ProblemFactory.Create(_problemNumber);
            if(problem != null)
            {
                var result = problem.GetResult();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Sorry, it looks like Ark Fen did not yet have time to solve this problem yet ))");
            }
        }
    }
}
