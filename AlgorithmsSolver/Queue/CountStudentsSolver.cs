using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Queue
{
    internal class CountStudentsSolver
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            int failsCount = 0;
            var studQueue = new Queue<int>(students);
            var sandwichQueue = new Queue<int>(sandwiches);

            while (studQueue.Count > 0 && failsCount < studQueue.Count)
            {
                var student = studQueue.Dequeue();
                if (student == sandwichQueue.Peek())
                {
                    sandwichQueue.Dequeue();
                    failsCount = 0;
                }
                else
                {
                    studQueue.Enqueue(student);
                    failsCount++;
                }
            }

            return failsCount;
        }
    }
}
