namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("How Many Number You Want To Sort");
            int qunt = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[qunt];
            BubbleSortLogic.insertElement(intArray);
            BubbleSortLogic.sortArray(intArray);
        }
    }
}