using System.Collections;

namespace InheritanceExercises
{
    class Stack
    {
        private readonly ArrayList StackList = new ArrayList();


        public void Push(object value)
        {
            Console.Clear();
            if(value == null)
            {
                throw new InvalidOperationException();
            }
            StackList.Add(value);
            Console.WriteLine(string.Format("`{0}` pushed to the Stack", value));
        }

        public void Pop()
        {
            Console.Clear();
            if(StackList.Count == 0)
            {
                throw new InvalidOperationException();
            }
            object poppedValue = StackList[StackList.Count - 1];
            if(poppedValue != null)
            {
                StackList.RemoveAt(StackList.Count - 1);
                Console.WriteLine(string.Format("`{0}` popped from the Stack", poppedValue));
            }
        }


        public void Clear()
        {
            Console.Clear();
            StackList.Clear();
            Console.WriteLine("The Stack has been cleared");
        }

    }
}
