namespace Data.MyColections
{
    public class MyStack<T>
    {
        public List<T> ListData = new List<T>();

        public void Push(T item) => ListData.Add(item);

        public T Peek() => ListData.Count > 0 ? ListData[^1] : throw new InvalidOperationException("Stack is empty.");

        public T Pop()

        {
            T item = Peek();
            ListData.RemoveAt(ListData.Count - 1);
            return item;
        }

        public bool IsEmpty() => ListData.Count == 0;

        public void Clear() => ListData.Clear();

        public void PrintStack()
        {
            for (int i = ListData.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(ListData[i]);
            }
        }

    }
}
