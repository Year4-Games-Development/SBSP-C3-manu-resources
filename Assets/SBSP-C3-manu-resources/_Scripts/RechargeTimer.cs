using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RechargeTimer :MonoBehaviour
{
    private ResearchModel researchModel;

    void Awake()
    {
        researchModel = new ResearchModel();
    }

    public ResearchModel GetResearchModel()
    {
        return researchModel;
    }

    private float countdownTimerStartTime;
    private int countdownTimerDuration;
    
    public int GetTotalSeconds()
    {
        return countdownTimerDuration;
    }
    
    public void ResetTimer(int seconds)
    {
        countdownTimerStartTime = Time.time;
        countdownTimerDuration = seconds;
    }

    public int GetSecondsRemaining()
    {
        int elapsedSeconds = GetElapsedSeconds();
        int secondsLeft = (countdownTimerDuration - elapsedSeconds);
        return secondsLeft;
    }

    public int GetElapsedSeconds()
    {
        int elapsedSeconds = (int)(Time.time - countdownTimerStartTime);
        return elapsedSeconds;
    }

    public float GetProportionTimeRemaining()
    {
        float proportionLeft = (float)GetSecondsRemaining() / (float)GetTotalSeconds();
        return proportionLeft;
    }

    //Research timers 
    public IEnumerator ScienceLv1Time()
    {
        yield return StartCoroutine(WaitForSecounds(researchModel.GetResearchTimeLv1()));
    }

    public IEnumerator ScienceLv2Time()
    {
        yield return StartCoroutine(WaitForSecounds(researchModel.GetResearchTimeLv2()));
    }

    public IEnumerator ScienceLv3Time()
    {
        yield return StartCoroutine(WaitForSecounds(researchModel.GetResearchTimeLv3()));
    }

     IEnumerator WaitForSecounds(float waitTime)
    {
        int i = 0;

        while(i>0)
        {
            yield return new WaitForSeconds(waitTime);
            i--;
        }
    }
    
}
