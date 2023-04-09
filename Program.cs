var arr = new List<int> {-4, 3, -9, 0, 4, 1}; 

List<int> positives = new List<int>();
List<int> negatives = new List<int>();
List<int> zeros = new List<int>();

foreach(var num in arr)
{
    if(num > 0) positives.Add(num);
    if(num == 0) zeros.Add(num);
    if(num < 0) negatives.Add(num);
}       

Console.WriteLine(Math.Round((double)positives.Count() / arr.Count(), 6));
Console.WriteLine(Math.Round((double)negatives.Count() / arr.Count(), 6));
Console.WriteLine(Math.Round((double)zeros.Count() / arr.Count(), 6));