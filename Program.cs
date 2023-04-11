List<List<int>> arr = new List<List<int>>
{
    new List<int> {1, 1, 1, 0, 0, 0},
    new List<int> {0, 1, 0, 0, 0, 0},
    new List<int> {1, 1, 1, 0, 0, 0},
    new List<int> {0, 0, 2, 4, 4, 0},
    new List<int> {0, 0, 0, 2, 0, 0},
    new List<int> {0, 0, 1, 2, 4, 0}
};

var lengthX = arr[0].Count; //row
var lengthY = arr.Count; //col
var sumTotal = new List<int>();

for (int x = 0; x < 4; x++)
{
    var sumHourGlass = 0;
    for (int y = 0; y < 4; y++)
    {
        sumHourGlass = arr[x][y] + arr[x][y+1] + arr[x][y+2] +
                                   arr[x+1][y+1] +
                       arr[x+2][y] + arr[x+2][y+1] + arr[x+2][y+2];
        sumTotal.Add(sumHourGlass);
    }
}

Console.WriteLine(sumTotal.Max());