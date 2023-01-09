using KnapsackLib;

var itemList = new List<Item>
{
    new("Gold ingot", 100, 5),
    new("Piece of sausage in dough", 20, 2),
    new("Shawarma", 50, 4)
};

const int knapsackCapacity = 10;

Console.WriteLine($"Knapsack capacity: {knapsackCapacity}");

var solvedList = KnapsackProblem.Solve(itemList, knapsackCapacity);

Console.WriteLine($"Solved list:\n{string.Join(", ", solvedList.Select(_ => _.Name))}");
Console.WriteLine($"Summary value: {solvedList.SummaryValue()}");
Console.WriteLine($"Summary weight: {solvedList.SummaryWeight()}");