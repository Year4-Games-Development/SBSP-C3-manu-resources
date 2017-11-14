public class Droid{

    private DroidModel _droidModel;

    public DroidModel GetDroidModel()
    {

        return _droidModel;

    }

    public void SetDroidModel(DroidModel model)
    {

        _droidModel = model;

    }

    public virtual void PerformDroidAction()
    {



    }
	
}

public enum DroidState
{
    Ready,
    Deployed,
    Charging,
    Repairing
}

public enum DroidType
{
    SearchDroid,
    RepairDroid
}
