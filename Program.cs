namespace LeetEulerWars;

class Program
{
    static void Main(string[] args)
    {
        int[] seq = new int[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 };
        // Console.WriteLine(find_intALT(seq));
        // curiousNumber(); // euler
        
        
        // work on this later.
    }

    public static int find_int(int[] seq) // find the odd int. codewars
    {
        List<int> num = new List<int>();
        List<int> occurrence = new List<int>();
        for (int i = 0; i < seq.Length; i++)
        {
            if (!num.Contains(seq[i]))
            {
                num.Add(seq[i]);
                occurrence.Add(1);
            }
            else if (num.Contains(seq[i]))
            {
                occurrence[num.IndexOf(seq[i])] += 1;
            }
        }

        int oddNumFound = 0;
        for (int i = 0; i < num.Count; i++)
        {
            Console.WriteLine($"{num[i]}, {occurrence[i]}");
            if ((occurrence[i] % 2) > 0)
            {
                oddNumFound = num[i];
            }
        }
        
        return oddNumFound;
    }

    public static int find_intALT(int[] seq) // find the odd int. codewars
    {
        return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
    }

    // public static void curiousNumber()
    // {
    //     for (int i = 3; i < 100; i++)
    //     {
    //         int currentSum = factorialSumGet(i);
    //     }
    // }
    //
    // public static int factorialSumGet(int n)
    // {
    //     int sum = 0;
    //     for (int i = 0; i < n.ToString().Length; i++)
    //     {
    //         
    //     }
    // }
}