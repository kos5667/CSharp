using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Part2.DataStructure {

    // 스택 : LIFO(후입선출 Last in First out)
    // 큐	: FIFO(선입선출 First in First out)

    // [1] [2] [3] [4]
    class StackQueue {

        /*
         * Stack 
         * ex) 순차적으로 UI 종료
         *     마지막으로 띄운 팝업을 종료해야한다.
         *     
         */
        public void Initalize() {
            Stack<int> stack = new Stack<int>();
            stack.Push(101);
            stack.Push(102);
            stack.Push(103);
            stack.Push(104);
            stack.Push(105);

            if (stack.Count > 0) { 
            }
            int data = stack.Pop();
            int data2 = stack.Peek();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(101);
            queue.Enqueue(102);
            queue.Enqueue(103);
            queue.Enqueue(104);
            queue.Enqueue(105);

            int data3 = queue.Dequeue();
            int data4 = queue.Peek();

            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(101);
            list.AddLast(102);
            list.AddLast(103);

            int value1 = list.First.Value;
            int value2 = list.Last.Value;

            list.RemoveFirst();
            list.RemoveLast();
        }

        static void Main(string[] args) {
            StackQueue stackQueue = new StackQueue();
            stackQueue.Initalize();
        }
    }
}
