using UnityEngine;
using UnityEngine.UI;

public class DroidBayView{

    private Button _deployButton;
    private Button _upgradeButton;
    private Button _removeButton;
    private Text _timerText;
    private Image _droidImage;

	public DroidBayView(Button deploy, Button upgrade, Button remove, Text timerText, Image droidImage)
    {

        _deployButton = deploy;
        _upgradeButton = upgrade;
        _removeButton = remove;
        _timerText = timerText;
        _droidImage = droidImage;

    }

    public Button GetDeployButton()
    {

        return _deployButton;

    }

    public Text GetTimerText()
    {

        return _timerText;

    }

    public Image GetDroidImage()
    {

        return _droidImage;

    }
}
