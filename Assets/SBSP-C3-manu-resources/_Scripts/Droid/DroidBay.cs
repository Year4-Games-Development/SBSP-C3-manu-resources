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
    public Text timerText;
    public Image droidImage;

    private DroidBayModel _droidBayModel;
    private DroidBayView _droidBayView;

    private RechargeTimer timer;


    void Awake()
    {
        _droidBayModel = new DroidBayModel();
        timer = new RechargeTimer();

        deployButton.onClick.AddListener(DeployDroid);
        upgradeButton.onClick.AddListener(UpgradeDroid);
        removeButton.onClick.AddListener(RemoveDroid);

        _droidBayView = new DroidBayView(deployButton, upgradeButton, removeButton, timerText, droidImage);
    }

    public DroidBayModel GetDroidBayModel()
    {
        return _droidBayModel;
    }

    public DroidBayView GetDroidView()
    {
        return _droidBayView;
    }

    public void DeployDroid()
    {

        StartCoroutine(timer.StartTimerCouroutine(10, this));

    }

    public void UpgradeDroid()
    {

        Debug.Log("Upgrading from: " + _droidBayModel.GetBayIndex());

    }

    public void RemoveDroid()
    {

        Debug.Log("Removing from: " + _droidBayModel.GetBayIndex());

    }

    public void OnStartTimer()
    {
        Debug.Log("Started Timer");

        _droidBayView.GetDeployButton().gameObject.SetActive(false);
        _droidBayView.GetTimerText().text = "10";
        _droidBayView.GetDroidImage().gameObject.SetActive(false);
    }

    public void OnIncrementTimer()
    {
        Debug.Log("Decrementing");

        _droidBayView.GetTimerText().text = "" + timer.GetRemainingSeconds();


    }

    public void OnFinishTimer()
    {
        Debug.Log("Finished");

        StopCoroutine(timer.GetCurrentCouroutine());
        _droidBayView.GetDeployButton().gameObject.SetActive(true);
        _droidBayView.GetTimerText().text = "Ready";
        _droidBayView.GetDroidImage().gameObject.SetActive(true);
    }
}
