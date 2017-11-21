using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class DroidBayModel : ITimeable
{

    private int _bayIndex;
    private Droid _currentDroid;
    private DroidManager _droidManager;

    //when model is updated, it will update view as well
    [SerializeField]
    private DroidBayView _droidBayView;

    private RechargeTimer _timer;

    public DroidBayModel(Button deploy, Button upgrade, Button remove, Button recharge,
        Button repair, Text statusText, Text droidTypeText, Text deployTimeText, Image droidImage , Text droidHealthText, Text droidEnergyText){
        
        _timer = new RechargeTimer();
        _droidBayView = new DroidBayView(deploy,upgrade,remove,recharge,
        repair, statusText, droidTypeText, deployTimeText, droidImage, droidHealthText, droidEnergyText);

        _droidBayView.CleanBay();

    }

    public void SetDroidManager(DroidManager manager)
    {

        _droidManager = manager;

    }

    public DroidManager GetDroidManager()
    {

        return _droidManager;

    }


    public RechargeTimer GetTimer()
    {

        return _timer;

    }

    public DroidBayView GetDroidBayView()
    {

        return _droidBayView;

    }

    public int GetBayIndex()
    {
        return _bayIndex;

    }

    public void SetBayIndex(int value)
    {
        _bayIndex = value;

    }

    public Droid GetDroid()
    {

        return _currentDroid;

    }

    public bool SetDroid(Droid droid)
    {

        if (_currentDroid == null)
        {
            
            if (droid != null)
            { 
                _currentDroid = droid;
                _droidBayView.GetDroidImage().sprite = droid.GetDroidModel().GetDroidView().GetDroidSprite();
                _droidBayView.EnableDroidImage();

                _currentDroid.GetDroidModel().SetCurrentDroidBay(GetDroidManager().GetDroidManagerModel().GetDroidBay(_bayIndex));

                _droidBayView.UpdateViewFromNewDroid(_currentDroid);
            }

            return true;

        }

        else if (_currentDroid != null && droid == null)
        {
                _currentDroid = null;
                _droidBayView.CleanBay();
        }

        return false;

    }

    public void OnStartTimer()
    {
        _droidBayView.UpdateStatusText(_timer.GetRemainingSecondsInt() + "");
        _droidBayView.DisableDroidImage();
        _droidBayView.DisableDeployButton();
    }

    public void OnIncrementTimer()
    {
        _droidBayView.UpdateStatusText(_timer.GetRemainingSecondsInt() + "");
    }

    public void OnFinishTimer()
    {
        _droidBayView.EnableDeployButton();
        _droidBayView.UpdateStatusText("Ready");
        _droidBayView.EnableDroidImage();

    }
}
