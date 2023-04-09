var clsnote = new NotesStore();

clsnote.AddNote("active", "DrinkTea");
clsnote.AddNote("active", "DrinkCoffee");
clsnote.AddNote("completed", "DrinkCoffee");

var result = clsnote.GetNotes("active");

Console.WriteLine(result);
public class NotesStore
{
    public static Dictionary<string, List<string>> Result { get; set; }  = new Dictionary<string, List<string>>();
    public List<string> statesResult = new List<string>();
    public void AddNote(string state, string name)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Name cannot be empty");
            
            var stateFormated = state.ToLower();

            if (ValidateState(stateFormated))
            {
                statesResult.Add(name);
                Result.Add(stateFormated, statesResult);
            }
        }
        catch (System.Exception ex)
        {
            Result.Add("error", new List<string>{ex.Message});
        }
    }

    private bool ValidateState(string state)
    {
        switch (state)
        {
            case "completed":
            case "active":
            case "others":
                return true;
            default:
                throw new Exception($"Error: Invalid state {state}");
        }
    }

    public List<String> GetNotes(string state)
    {
        var retrn = new List<string>();
        var st = state.ToLower();
        switch (st)
        {
            case "completed":
                retrn.AddRange(Result[st]);
                break;
            case "active":
                retrn.AddRange(Result[st]);
                break;
            case "others":
                retrn.AddRange(Result[st]);
                break;
            default:
                retrn.Add($"Error: Invalid state {state}");
                break;
                //throw new Exception($"Invalid state {state}");
        }

        return retrn;
    }
}

