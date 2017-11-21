public class RepairDroid : Droid
{

    public RepairDroid()
    {

        SetDroidModel(new RepairDroidModel());
        
    }

    public override void PerformDroidAction()
    {
        base.PerformDroidAction();
    }

}
