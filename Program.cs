var A = new List<int> {1, 2, 2, 1};
var B = new List<int> {3, 3, 3, 4};
var k = 5;

A.Sort();
B.Sort();
B.Reverse();
for (int i = 0; i < A.Count; i++)
{
    if (A[i] + B[i] < k)
        Console.WriteLine("NO");
}
Console.WriteLine("YES");