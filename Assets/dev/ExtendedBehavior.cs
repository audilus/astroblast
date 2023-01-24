using UnityEngine;
using System.Collections;
using System;

public class ExtendedBehavior : MonoBehaviour
{
    #region waiting
    bool pWait_isRunning;
    IEnumerator _performAndWait(Action callback, float time)
    {
        pWait_isRunning = true;
        callback();
        yield return new WaitForSeconds(time);
        pWait_isRunning = false;
    }
    bool wait_isRunning;
    public void Wait(float seconds, Action action)
    {
        if (!wait_isRunning){

            StopCoroutine(_waitAndPerform(seconds, action));
            StartCoroutine(_waitAndPerform(seconds, action));
        
        }
    }

    public void Wait(float seconds)
    {
        StopCoroutine(_wait(seconds));
        StartCoroutine(_wait(seconds));
    }

    public void PerformAndWait(float seconds, Action action)
    {
        if (!pWait_isRunning)
        {
            StartCoroutine(_performAndWait(action, seconds));
        }
        
    }

    public IEnumerator _waitAndPerform(float time, Action callback)
    {
        wait_isRunning = true;
        yield return new WaitForSeconds(time);
        callback();
        wait_isRunning = false;
    }

    IEnumerator _wait(float time){
        yield return new WaitForSeconds(time);
    }
    #endregion

}

