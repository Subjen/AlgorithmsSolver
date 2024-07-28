using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Queue
{
    public class RecentCounter
    {
        private readonly Queue<int> requests;
        private const int Time = 3000;

        public RecentCounter()
        {
            requests = new Queue<int>();
        }

        public int Ping(int t)
        {
            requests.Enqueue(t);

            while (t - Time > requests.Peek())
            {
                requests.Dequeue();
            }

            return requests.Count;
        }
    }
}
