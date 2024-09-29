

//Implement a last-in-first-out (LIFO) stack using only two queues.The implemented stack should support all the functions of a normal stack (push, top, pop, and empty).

//Implement the MyStack class:

//void push(int x) Pushes element x to the top of the stack.
//int pop() Removes the element on the top of the stack and returns it.
//int top() Returns the element on the top of the stack.
//boolean empty() Returns true if the stack is empty, false otherwise.
//Notes:

//You must use only standard operations of a queue, which means that only push to back, peek/pop from front, size and is empty operations are valid.
//Depending on your language, the queue may not be supported natively. You may simulate a queue using a list or deque(double-ended queue) as long as you use only a queue's standard operations.
namespace Implement_Stack_Using_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public class MyStack
        {
            List<int> stackDb = new List<int>();
            public MyStack()
            {

            }

            public void Push(int x)
            {
                stackDb.Insert(0, x);
            }

            public int Pop()
            {
                int poppedNumber = stackDb[0];
                stackDb.RemoveAt(0);
                return poppedNumber;
            }

            public int Top()
            {
                return stackDb[0];
            }

            public bool Empty()
            {
                if (stackDb.Count == 0)
                {
                    return true;
                }
                return false;
            }
        }

        /**
         * Your MyStack object will be instantiated and called as such:
         * MyStack obj = new MyStack();
         * obj.Push(x);
         * int param_2 = obj.Pop();
         * int param_3 = obj.Top();
         * bool param_4 = obj.Empty();
         */
    }
}
