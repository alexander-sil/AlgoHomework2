namespace AlgoHomework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            // Проверка работоспособности двусвязного списка

            DoublyLinkedList dll = new DoublyLinkedList();

            dll.AddNode(11);
            dll.AddNode(33);

            dll.AddNodeAfter(dll.FindNode(11), 22);

            Console.WriteLine("Кол-во элементов в двусвязном списке: " + dll.GetCount());

            dll.RemoveNode(0);
            dll.RemoveNode(dll.FindNode(22));

            Console.WriteLine("Кол-во элементов в двусвязном списке: " + dll.GetCount());


            Console.WriteLine("====================================");

            // Проверка работоспособности двоичного поиска

            int[] array = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            Array.Sort(array);

            int found = BinSearch.BinarySearch(array, 0);

            Console.WriteLine($"Найден элемент массива на {found}-ом индексе: {array[found]}");


        }
    }
}