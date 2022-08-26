using System;
using System.Collections;
using UnityEngine;

public class GameChecker : MonoBehaviour
{
    private WaitForSeconds _waitForSeconds;
    public static Action OnWinned;
    public static bool GameWinned;

    private IEnumerator ResetScreen()
    {
        yield return _waitForSeconds;
        ScreenFade.ScreenReset();
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
        if (BallsInfo.BallsIntoTrigger == BallsInfo.BallsNeedToWin)
        {
            StopCoroutine(ResetScreen());
            GameWinned = true;
            OnWinned?.Invoke();
        }

        if (BallsInfo.ActualBalls == 0)
        {
            CannonShooting.CouldShoot = false;
            if (!GameWinned)
                StartCoroutine(ResetScreen());
        }
    }
}