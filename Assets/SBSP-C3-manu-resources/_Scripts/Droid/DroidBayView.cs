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

        _droidImage.gameObject.SetActive(false);

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

    public Button GetRepairButton()
    {

        return _repairButton;

    }

    public Button GetRechargeButton()
    {

        return _rechargeButton;

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

    public Text GetDroidTypeText()
    {

        return _droidTypeText;

    }

    public Text GetDroidDeployTimeText()
    {

        return _droidDeployTimeText;

    }

    public Text GetDroidHealthText()
    {

        return _droidHealthText;

    }

    public Text GetDroidEnergyText()
    {

        return _droidEnergyText;

    }

    public void SetDroidTypeText(Droid droid)
    {

        _droidTypeText.text = droid.GetDroidModel().GetDroidTypeString();

    }

    public void SetDroidDeployTimeText(Droid droid)
    {

        _droidDeployTimeText.text = droid.GetDroidModel().GetDroidDeployTime() + " secs";

    }

    public void SetDroidHealthText(Droid droid)
    {

        _droidHealthText.text = droid.GetDroidModel().GetDroidCurrentHealth() + "/" + droid.GetDroidModel().GetDroidMaxHealth();

    }

    public void SetDroidEnergyText(Droid droid)
    {

        _droidEnergyText.text = droid.GetDroidModel().GetDroidCurrentEnergy() + "/" + droid.GetDroidModel().GetDroidMaxEnergy();

    }

    public void UpdateViewFromNewDroid(Droid droid)
    {
        SetDroidTypeText(droid);
        SetDroidDeployTimeText(droid);
        SetDroidHealthText(droid);
        SetDroidEnergyText(droid);

        _deployButton.interactable = true;
        _upgradeButton.interactable = true;
        _removeButton.interactable = true;
        _rechargeButton.interactable = true;
        _repairButton.interactable = true;
        _droidTypeText.gameObject.SetActive(true);
    }

    public void CleanBay()
    {


        _deployButton.interactable = false;
        _upgradeButton.interactable = false;
        _removeButton.interactable = false;
        _rechargeButton.interactable = false;
        _repairButton.interactable = false;
        _droidTypeText.gameObject.SetActive(false);
        _droidImage.gameObject.SetActive(false);

    }

}
