var grades = new List<int> 
{
    73,67,38,33
};
var result = new List<int>();
for (int i = 0; i < grades.Count; i++)
{
    if (grades[i] >= 38)
    {
        if((grades[i])%5 >= 3)
        {
            result.Add(grades[i] + (5-grades[i]%5));
        }
        else
        {
            result.Add(grades[i]);
        }
    }
    else
    {
        result.Add(grades[i]);
    }
}

result.ForEach(r => Console.WriteLine(r));