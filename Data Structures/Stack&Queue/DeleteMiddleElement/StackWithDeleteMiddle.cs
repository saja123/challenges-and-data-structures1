using challenges_and_data_structures1;

namespace StackAndQueue.DeleteMiddleElement
{
    public class StackWithDeleteMiddle : Stack
    {
        public int DeleteMiddle()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is empty");

            int count = 0;
            Stack tempStack = new Stack();

            while (!IsEmpty())
            {
                tempStack.Push(Pop());
                count++;
            }

            int middleIndex = (count % 2 == 0) ? (count / 2) - 1 : count / 2;
            int middleElement = 0;

            for (int i = 0; i < count; i++)
            {
                if (i == middleIndex)
                {
                    middleElement = tempStack.Pop();
                }
                else
                {
                    Push(tempStack.Pop());
                }
            }

            return middleElement;
        }

    }
}
