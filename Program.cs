using W1Algos;
namespace AlgoPart1
{
    class Program
    {
        public static void Main(){
            QuickFindUF _quickFindUF = new(10);
            _quickFindUF.PrintArray();
            _quickFindUF.Union(1, 0);
            /*_quickFindUF.Union(1, 2);
            _quickFindUF.Union(1, 4);*/
            _quickFindUF.PrintArray();
            Console.WriteLine(_quickFindUF.Connected(2,4));
        }
    }
}