using System;
using System.Collections;
using UnityEngine;

public class scr_GameChecker : MonoBehaviour
{
    private WaitForSeconds _waitForSeconds;
    public static Action OnWinned;
    public static bool GameWinned;

    private IEnumerator ResetScreen()
    {
        yield return _waitForSeconds;
        scr_ScreenFade.ScreenReset();
    }

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(3f);
    }

    private void Start()
    {
        GameWinned = false;
    }

    private void Update()
    {
        if (scr_BallsInfo.BallsIntoTrigger == scr_BallsInfo.BallsNeedToWin)
        {
            StopCoroutine(ResetScreen());
            GameWinned = true;
            OnWinned?.Invoke();
        }

        if (scr_BallsInfo.ActualBalls == 0)
        {
            scr_CannonShooting.CouldShoot = false;
            if (!GameWinned)
                StartCoroutine(ResetScreen());
        }
    }
}