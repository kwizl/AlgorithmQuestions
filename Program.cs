using System;
using AlgoExpert.Easy;
using AlgoExpert.Medium;

namespace AlgoExpert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 2, 2, 2, 3, 4, 2 };
            MoveElement moveElement = new MoveElement();
            moveElement.ToEnd(array, 2);
        }
    }
}
