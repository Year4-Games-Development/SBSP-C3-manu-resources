public class DroidModel{

    protected int _maxHealth;
    protected int _maxEnergy;
    protected int _currentHealth;
    protected int _currentEnergy;
    protected int _deployTime;

    protected DroidView _droidView;

    protected DroidState _droidState;
    protected DroidType _droidType;

    private DroidBay _currentDroidBay;
    

    public DroidModel()
    {
        _droidView = new DroidView();
        _droidState = DroidState.Ready;

    }

    public void SetCurrentDroidBay(DroidBay bay)
    {

        _currentDroidBay = bay;

    }

    public DroidBay GetCurrentDroidBay()
    {

        return _currentDroidBay;

    }

    public DroidView GetDroidView()
    {

        return _droidView;

    }

    public bool ChangeDroidState(DroidState state)
    {

        _droidState = state;

        return true;

    }

    public string GetDroidStateString()
    {

        return _droidState.ToString();

    }

    public string GetDroidTypeString()
    {

        return _droidType.ToString();

    }

    public int GetDroidMaxHealth()
    {

        return _maxHealth;

    }

    public int GetDroidCurrentHealth()
    {

        return _currentHealth;

    }

    public int GetDroidMaxEnergy()
    {

        return _maxEnergy;

    }

    public int GetDroidCurrentEnergy()
    {

        return _currentEnergy;

    }

    public int GetDroidDeployTime()
    {

        return _deployTime;

    }


}
