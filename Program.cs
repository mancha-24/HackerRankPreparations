var matrix = new List<List<int>>
{
    // new List<int> {112,42,83,119},
    // new List<int> {56,125,56,49},
    // new List<int> {15,78,108,43},
    // new List<int> {62,98,114,108},
    new List<int> {1,2},
    new List<int> {3,4}
};

Console.WriteLine(flippingMatrix(matrix));

static int flippingMatrix(List<List<int>> matrix)
{
   int queryLength = matrix[0].Count() - 1;
   int halfQueryLength = (matrix[0].Count() / 2) - 1;
   int maxSum = 0;
   for(int row = 0; row <= halfQueryLength; row++){
      for(int col = 0; col <= halfQueryLength; col++){
         var counter = new List<int>(){
            matrix[row][col],
            matrix[row][queryLength - col],
            matrix[queryLength - row][col],
            matrix[queryLength - row][queryLength - col],
         };
         maxSum += biggerNumber(counter);
      }
   }
   return maxSum;
}

static int biggerNumber(List<int> numberList){
   int bigger = 0;
   foreach(var num in numberList){
      bigger = Math.Max(bigger, num);
   }
   return bigger;
}