       //1  23 456 78901   234   56  78   90
       //SOSSOSSOSSOSSOSSOSSOSSOSSOSSOSSOSSOS
var s = "OOSDSSOSOSWEWSOSOSOSOSOSOSSSSOSOSOSS";
var chr = s.ToCharArray();
var countSignals = 0;
var countErrors = 0;
var sos = "SOS".ToCharArray();

if (chr.Count()%3 == 0)
    countSignals = chr.Count() / 3;

for (int i = 0; i < countSignals; i++)
{
    var signal = s.Substring(i*3,3);
    for (int j = 0; j < sos.Count(); j++)
    {
        if (signal[j] != sos[j])
            countErrors++;
    }
}

Console.WriteLine(countErrors);