namespace W1Algos
{

    internal class QuickFindUF
    {
        internal int[] id;

        internal QuickFindUF(int N)
        {
            id = new int[N];
            for (int i = 0; i < N; i++)
            {
                id[i] = i;
            }
        }

        internal bool Connected(int p, int q)
        {
            return id[p] == id[q];
        }

        internal void Union(int p, int q)
        {
            int pid = id[p];
            int qid = id[q];

            for (int i = 0; i < id.Length; i++)
            {
                if (pid == id[i]) id[i] = qid;
            }
        }

        internal void PrintArray()
        {
            for (int i = 0; i < id.Length; i++)
            {
                Console.Write(i + ":" + id[i]);
                if (i != id.Length - 1) Console.Write("|");
            }
            Console.WriteLine();
        }

    }
}
