namespace KnapsackLib;

public static class KnapsackProblem
{
    public record Item(string Name, int Value, int Weight);

    // Method solve knapsack problem
    public static List<Item> Solve(List<Item> items, int capacity)
    {
        // Create matrix
        var matrix = new int[items.Count + 1, capacity + 1];

        // Fill matrix
        int i;
        int j;
        for (i = 1; i <= items.Count; i++)
        {
            for (j = 1; j <= capacity; j++)
            {
                if (items[i - 1].Weight > j)
                {
                    matrix[i, j] = matrix[i - 1, j];
                }
                else
                {
                    matrix[i, j] = Math.Max(matrix[i - 1, j], matrix[i - 1, j - items[i - 1].Weight] + items[i - 1].Value);
                }
            }
        }

        // Find items
        var result = new List<Item>();
        i = items.Count;
        j = capacity;
        while (i > 0 && j > 0)
        {
            if (matrix[i, j] != matrix[i - 1, j])
            {
                result.Add(items[i - 1]);
                j -= items[i - 1].Weight;
            }

            i--;
        }

        return result;
    }
    
    public static int SummaryValue(this List<Item> items)
    {
        return items.Sum(_ => _.Value);
    }
    
    public static int SummaryWeight(this List<Item> items)
    {
        return items.Sum(_ => _.Weight);
    }
}