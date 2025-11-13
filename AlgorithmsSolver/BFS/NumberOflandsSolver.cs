using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.BFS
{
    //leetcode.com/problems/number-of-islands/description/
    internal class NumberOflandsSolver
    {
        public int NumIslands(char[][] grid)
        {
            int counter = 0;
            void GoNext(int i , int j)
            {
                if (i < grid.Length - 1 && grid[i + 1][j] == '1')
                    GoNext(i + 1, j);
                if (j < grid[i].Length - 1 && grid[i][j + 1] == '1')
                    GoNext(i, j + 1);
                grid[i][j] = '-';
                if (i > 0 && grid[i - 1][j] == '1')
                    GoNext(i - 1, j);
                if (j > 0 && grid[i][j - 1] == '1')
                    GoNext(i, j - 1);
            }

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        GoNext(i, j);
                        counter++;
                    }
                }
            }

            return counter;

        }
    }
}
