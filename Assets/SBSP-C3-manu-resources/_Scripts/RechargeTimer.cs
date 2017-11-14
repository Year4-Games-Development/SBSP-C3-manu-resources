using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RechargeTimer
{

    private float countdownTimerStartTime;
    private int countdownTimerDuration;
    private int seconds;

    private IEnumerator couroutine;

    public RechargeTimer()
    {

    }

    public RechargeTimer(int timer)
    {

        countdownTimerDuration = timer;

    }

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

    private IEnumerator DecrementTimer(int seconds, ITimeable callback)
    {

        this.seconds = seconds;

        callback.OnStartTimer();

        while (this.seconds > 0)
        {
            yield return new WaitForSeconds(1f);
            this.seconds--;
            callback.OnIncrementTimer();
        }

        callback.OnFinishTimer();

    }

    public IEnumerator GetCurrentCouroutine()
    {
        return couroutine;
    }

    public IEnumerator StartTimerCouroutine(int seconds, ITimeable callback)
    {

        couroutine = DecrementTimer(seconds, callback);

        return couroutine;

    }

    public int GetRemainingSecondsInt()
    {

        return seconds;

    }

    public string GetRemainingSecondsString()
    {

        return seconds + "";

    }

}
