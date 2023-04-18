int x1 = 0; //posicion canguro 1
int v1 = 3; //pasos por salto canguro 1
int x2 = 4; //posicion canguro 2
int v2 = 2; //pasos por salto canguro 2

if (v1 > v2 && (x2 - x1)%(v1 - v2) == 0) Console.WriteLine("YES");
Console.WriteLine("NO");