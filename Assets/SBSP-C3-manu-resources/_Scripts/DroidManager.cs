using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroidManager : MonoBehaviour
{
    public DroidPlayer droid;
    private RechargeTimer countDownTimer;
    private int totalSeconds = 60;

    void Start()
    {
        countDownTimer = GetComponent<RechargeTimer>();
        countDownTimer.ResetTimer(totalSeconds);
    }
    void Update()
    {
        string msg = "Seconds Left:" + countDownTimer.GetSecondsRemaining();
        print(msg);

        CheckDroidStatus();
    }
    private void CheckDroidStatus()
    {
        
        if (countDownTimer.GetSecondsRemaining() < 0)
        {
            //droid.Activate();
        }
    }
}
