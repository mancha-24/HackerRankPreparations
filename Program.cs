var ar = new List<int> {10, 20, 20, 10, 10, 30, 50, 10, 20 }; 
int pairCount = 0;

Dictionary<int, int> dict = new Dictionary<int, int>();
for (int i = 0; i < ar.Count; i++) {
    if (dict.ContainsKey(ar[i])) {
        dict[ar[i]]++;
    } else {
        dict[ar[i]] = 1;
    }
}

foreach (int value in dict.Values) {
    pairCount += value / 2;
}

return pairCount;