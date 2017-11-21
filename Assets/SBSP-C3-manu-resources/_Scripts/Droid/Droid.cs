using UnityEngine;

public class Droid : Item
{

    private DroidModel _droidModel;

    public Droid()
    {
        _droidModel = new RepairDroidModel();

    }

    public Droid(DroidModel model)
    {

        _droidModel = model;

    }

    public DroidModel GetDroidModel()
    {

        return _droidModel;
    }

    public void SetDroidModel(DroidModel model)
    {

        _droidModel = model;

    }

    public override bool UseItem(MainResourceController main , Item item)
    {
        return main.GetDroidManager().AddDroidToBay((Droid)item);
    }

    public virtual void PerformDroidAction()
    {

    }

    public virtual void FinishDroidAction()
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
