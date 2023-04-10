var n = 4;
var stairs = new List<string>();

for (int i = 0; i < n; i++)
{
    var chr = string.Empty;
    var padded = string.Empty;
    for (int j = 0; j <= i; j++)
    {
        chr += "#";
    }
    padded = chr.PadLeft(n);
    stairs.Add(padded);
}
    
stairs.ForEach(s => Console.WriteLine(s));