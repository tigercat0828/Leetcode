using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P232_Implement_Queue_using_Stacks {
        private Stack<int> stackQueue;
        private Stack<int> stackTmp;
        public P232_Implement_Queue_using_Stacks() {
            stackQueue = new Stack<int>();
            stackTmp = new Stack<int>();
        }
        public void Push(int x) {
            // move element from queue to temp
            while (stackQueue.Count > 0) {
                int pop = stackQueue.Pop();
                stackTmp.Push(pop);
            }
            stackQueue.Push(x);
            // move element from temp to queue
            while (stackTmp.Count > 0) {
                int pop = stackTmp.Pop();
                stackQueue.Push(pop);
            }
        }

        public int Pop() {
            return stackQueue.Pop();
        }

        public int Peek() {
            return stackQueue.Peek();
        }

        public bool Empty() {
            return stackQueue.Count == 0;
        }
    }
}
