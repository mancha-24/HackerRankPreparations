var steps = 12;
var path = "DDUUDDUDUUUD";
var pathChar = path.ToCharArray().ToList();
var valleyStart = 0;
var valleyCount = 0;

for (int i = 0; i < steps; i++)
{
    if (path[i] == 'U')
    {
        valleyStart +=1;
    }
    else
    {
        valleyStart -=1;
    }

    if (valleyStart == 0 && path[i] == 'U')
        valleyCount+=1;
}

Console.WriteLine(valleyCount);

// _/\      _
//    \    /
//     \/\/

// _          /\ 
//  \  /\    /
//   \/  \/\/