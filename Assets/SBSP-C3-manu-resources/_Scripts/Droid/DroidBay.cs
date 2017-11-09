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

        _droidBayModel.GetDroidBayView().GetDeployButton().onClick.AddListener(DeployDroid);
        _droidBayModel.GetDroidBayView().GetUpgradeButton().onClick.AddListener(UpgradeDroid);
        _droidBayModel.GetDroidBayView().GetRemoveButton().onClick.AddListener(RemoveDroid);

        _droidBayModel = new DroidBayModel(deployButton, upgradeButton, removeButton,rechargeButton,repairButton, statusText,droidTypeText,deployTimeText, droidImage, droidHealthText, droidEnergyText);

        

    }

    public DroidBayModel GetDroidBayModel()
    {
        return _droidBayModel;
    }

    public void DeployDroid()
    {

        StartCoroutine(_droidBayModel.GetTimer().StartTimerCouroutine(10, this));

    }

    public void UpgradeDroid()
    {

        AddDroidToBay(DroidFactory.instance.CreateDroid(0));

    }

    public void RemoveDroid()
    {


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

    public void AddDroidToBay(Droid droid)
    {

        _droidBayModel.SetDroid(droid);

    }
}
