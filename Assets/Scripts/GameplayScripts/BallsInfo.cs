using UnityEngine;

public class BallsInfo : MonoBehaviour
{
    [SerializeField] private LevelSettings _levelSettings;
    public static int ActualBalls;
    public static int BallsNeedToWin;
    public static int BallsIntoTrigger;

    private void OnEnable()
    {
        CannonShooting.IsShooting += IncActualBalls;
        BallEnteredTrigger.OnTriggered += IncNeedToWinBalls;
    }

    private void OnDisable()
    {
        CannonShooting.IsShooting -= IncActualBalls;
        BallEnteredTrigger.OnTriggered -= IncNeedToWinBalls;
    }

    private void Start()
    {
        BallsIntoTrigger = 0;
        ActualBalls = _levelSettings.MaxBalls;
        BallsNeedToWin = _levelSettings.NeedBallsToWin;
    }

    private void IncNeedToWinBalls()
    {
        if (BallsIntoTrigger < BallsNeedToWin)
        {
            BallsIntoTrigger++;
            ResetNeedToWinBalls.ResetText(BallsIntoTrigger);
        }
    }

    private void IncActualBalls()
    {
        if (ActualBalls == 0) return;

        ActualBalls--;
        ResetActuallBallsText.ResetText();
    }
}