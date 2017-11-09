public class Droid{

    private DroidModel _droidModel;

    private DroidState _droidState;

    public Droid()
    {

        _droidModel = new DroidModel();
        _droidState = DroidState.Ready;

    }

    public DroidModel GetDroidModel()
    {

        return _droidModel;

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
	
}

public enum DroidState
{
    Ready,
    Deployed,
    Charging,
    Repairing
}
