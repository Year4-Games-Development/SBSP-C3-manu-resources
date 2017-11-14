using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroidBay : MonoBehaviour, ITimeable
{

    public Button deployButton;
    public Button upgradeButton;
    public Button removeButton;
    public Button rechargeButton;
    public Button repairButton;
    public Text statusText;
    public Text droidTypeText;
    public Text deployTimeText;
    public Text droidHealthText;
    public Text droidEnergyText;
    public Image droidImage;

    [SerializeField]
    private DroidBayModel _droidBayModel;

    void Awake()
    {

        _droidBayModel = new DroidBayModel(deployButton, upgradeButton, removeButton,rechargeButton,repairButton, statusText,droidTypeText,deployTimeText, droidImage, droidHealthText, droidEnergyText);

        _droidBayModel.GetDroidBayView().GetDeployButton().onClick.AddListener(DeployDroid);
        _droidBayModel.GetDroidBayView().GetUpgradeButton().onClick.AddListener(UpgradeDroid);
        _droidBayModel.GetDroidBayView().GetRemoveButton().onClick.AddListener(RemoveDroid);

    }

    public DroidBayModel GetDroidBayModel()
    {
        return _droidBayModel;
    }

    public void DeployDroid()
    {
        if (_droidBayModel.GetDroid() != null)
        {

            StartCoroutine(_droidBayModel.GetTimer().StartTimerCouroutine(_droidBayModel.GetDroid().GetDroidModel().GetDroidDeployTime(), this));

        }
    }

    public void UpgradeDroid()
    {
        if (_droidBayModel.GetDroid() == null)
            AddDroidToBay(DroidFactory.instance.CreateDroid(DroidType.SearchDroid));

    }

    public void RemoveDroid()
    {

        //if (_droidBayModel.GetDroid() != null)

    }

    public void OnStartTimer()
    {
        _droidBayModel.OnStartTimer();
    }

    public void OnIncrementTimer()
    {
        _droidBayModel.OnIncrementTimer();
    }

    public void OnFinishTimer()
    {
        _droidBayModel.OnFinishTimer();
        StopCoroutine(_droidBayModel.GetTimer().GetCurrentCouroutine());
    }

    public bool AddDroidToBay(Droid droid)
    {

        if (!_droidBayModel.SetDroid(droid))
            return false;

        return true;

    }
}
