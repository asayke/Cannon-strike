using System;
using System.Collections;
using UnityEngine;

public class scr_GameChecker : MonoBehaviour
{
    private WaitForSeconds _waitForSeconds;

    private IEnumerator ResetScreen()
    {
        yield return _waitForSeconds;
        scr_ScreenFade.ScreenReset();
    }

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(3f);
    }

    private void Update()
    {
        if (scr_BallsInfo.ActualBalls == 0)
            StartCoroutine(ResetScreen());
    }
}