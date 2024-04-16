namespace Services
{
    public class Container<T>
    {
        private List<T> _list = new List<T>();

        public void AddItem(T item)
        {
            _list.Add(item);
        }

        public void PrintAll()
        {

            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
