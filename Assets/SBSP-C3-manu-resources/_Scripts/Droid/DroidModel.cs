using System.Collections.Generic;

public class DroidModel{

    protected int _maxHealth;
    protected int _maxEnergy;
    protected int _currentHealth;
    protected int _currentEnergy;
    protected int _deployTime;
    protected int _energyConsuption;

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

    public int GetEnergyConsumption()
    {

        return _energyConsuption;

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

    public DroidState GetDroidState()
    {

        return _droidState;

    }

    public void SetDroidState(DroidState state)
    {

        _droidState = state;

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

    public void SetDroidCurrentEnergy(int value)
    {
        _currentEnergy = value;
    }


}
