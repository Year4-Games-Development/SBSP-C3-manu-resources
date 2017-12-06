public class Manufacture
{
    private string _name;
    private string _description;
    private int _cost;
    private bool _isLearned;
    private int _timeToManufacture;

    AllManufacture _thisManufacture;
    //AllResearches _thisResearch;

    public Manufacture(string name, string description, AllManufacture manufacture, int cost)
    {
        _name = name;
        _description = description;
        _thisManufacture = manufacture;
        _isLearned = false;
        _cost = cost;
    }

    public bool IsLearned()
    {
        return _isLearned;
    }

    public AllManufacture GetManufacture()
    {
        return _thisManufacture;
    }

    public void SetLearned(bool value)
    {
        _isLearned = value;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetCost(int value)
    {
        _cost = value;
    }

    public int GetCost()
    {
        return _cost;
    }

    /*public AllResearches GetResearch()
    {
        return _thisResearch;
    }*/
}

public enum AllManufacture
{
    Machinegun,
    Rockets,
    RepairDroid,
    SeaechDroid,
    Ammo,
    Fuel
}