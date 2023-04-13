// s: integer, starting point of Sam's house location.
// t: integer, ending location of Sam's house location.
// a: integer, location of the Apple tree.
// b: integer, location of the Orange tree.
// apples: integer array, distances at which each apple falls from the tree.
// oranges: integer array, distances at which each orange falls from the tree.

var s = 7;
var t = 11;
var a = 5;
var b = 15;
var apples = new List<int>
{
    -2,2,1
};
var oranges = new List<int>
{
    5,-6
};

var countApples = apples.Count(ap => (ap+a) >= s && (ap+a) <= t);
var countOranges = oranges.Count(or => (or+b) >= s && (or+b) <= t);

Console.WriteLine(countApples);
Console.WriteLine(countOranges);