public class DroidModel{

    private int _health;
    private int _energy;
    private int _deployTime;

    private DroidView _droidView;

    public DroidModel()
    {

        _health = 10;
        _energy = 10;
        _deployTime = 10;

        _droidView = new DroidView();

    }

    public DroidView GetDroidView()
    {

        return _droidView;

    }

}
