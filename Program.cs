var s = "the quick brown fox jumps over the lazy dog";
s = s.ToLower();
char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

foreach (var letter in alphabet)
{
    if (!s.Contains(letter))
    {
        Console.WriteLine("not pangram");
    }
}

Console.WriteLine("pangram");