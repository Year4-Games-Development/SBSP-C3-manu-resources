public class Research
{
    private string _researchName;
    private string _description;

    private bool _isLearned;
    private int _timeToLearn;

    AllResearches _thisResearch;
    
    public Research(string name, string description, AllResearches research, int time)
    {
        _researchName = name;
        _description = description;
        _thisResearch = research;
        _isLearned = false;
        _timeToLearn = time;
    }

    public bool IsLearned()
    {
        return _isLearned;
    }

    public AllResearches GetResearch()
    {
        return _thisResearch;
    }

    public void SetLearned(bool value)
    {
        _isLearned = value;
    }

    public void SetName(string name)
    {
        _researchName = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetName()
    {
        return _researchName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetTime(int value)
    {
        _timeToLearn = value;
    }

    public int GetTime()
    {
        return _timeToLearn;
    }
}

public enum AllResearches
{
    More_Bays,
    Machinegun,
    Rockets
}
