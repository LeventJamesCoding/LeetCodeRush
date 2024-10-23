namespace Implement_Queue_using_Stacks
{
    public class MyQueue
    {
        List<int> stack = new List<int>();
        public MyQueue()
        {

        }

        public void Push(int x)
        {
            stack.Add(x);
        }

        public int Pop()
        {
            int returnedElement = stack[0];
            stack.RemoveAt(0);
            return returnedElement;
        }

        public int Peek()
        {
            return stack[0];
        }

        public bool Empty()
        {
            if(stack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}