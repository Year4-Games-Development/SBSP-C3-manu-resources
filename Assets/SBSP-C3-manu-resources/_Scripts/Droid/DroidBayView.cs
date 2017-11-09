using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class DroidBayView{

    private Button _deployButton;
    private Button _upgradeButton;
    private Button _removeButton;
    private Button _rechargeButton;
    private Button _repairButton;
    private Text _statusText;
    private Text _droidTypeText;
    private Text _droidDeployTimeText;
    private Image _droidImage;
    public Text _droidHealthText;
    public Text _droidEnergyText;

	public DroidBayView(Button deploy, Button upgrade, Button remove, Button recharge,
        Button repair, Text statusText,Text droidTypeText,Text deployTimeText, Image droidImage, Text droidHealthText, Text droidEnergyText){

        _deployButton = deploy;
        _upgradeButton = upgrade;
        _removeButton = remove;
        _rechargeButton = recharge;
        _repairButton = repair;
        _statusText = statusText;
        _droidTypeText = droidTypeText;
        _droidDeployTimeText = deployTimeText;
        _droidImage = droidImage;
        _droidHealthText = droidHealthText;
        _droidEnergyText = droidEnergyText;

    }

    public Button GetDeployButton()
    {

        return _deployButton;

    }

    public Button GetUpgradeButton()
    {

        return _upgradeButton;

    }

    public Button GetRemoveButton()
    {

        return _removeButton;

    }

    public Text GetStatusText()
    {

        return _statusText;

    }

    public Image GetDroidImage()
    {

        return _droidImage;

    }

    public bool EnableDroidImage()
    {

        if (_droidImage.IsActive())
            return false;

        _droidImage.gameObject.SetActive(true);

        return true;

    }

    public bool DisableDroidImage()
    {

        if (!_droidImage.IsActive())
            return false;

        _droidImage.gameObject.SetActive(false);

        return true;

    }

    public bool EnableDeployButton()
    {

        if (_deployButton.IsActive())
            return false;

        _deployButton.gameObject.SetActive(true);

        return true;

    }

    public bool DisableDeployButton()
    {
        if (!_deployButton.IsActive())
            return false;

        _deployButton.gameObject.SetActive(false);

        return true;

    }

    public void UpdateStatusText(string value)
    {

        _statusText.text = value;

    }
}
