var candles = new List<int> {3,2,1,3};
var max = candles.Max();
var countMax = candles.Count(c => c == max);

Console.WriteLine(countMax);