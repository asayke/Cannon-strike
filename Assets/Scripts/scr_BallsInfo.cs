using UnityEngine;

public class scr_BallsInfo : MonoBehaviour
{
    [SerializeField] private LevelSettings _levelSettings;
    public static int ActualBalls;
    public static int BallsNeedToWin;
    public static int BallsIntoTrigger;

    private void OnEnable()
    {
        scr_CannonShooting.IsShooting += IncActualBalls;
        scr_BallEnteredTrigger.OnTriggered += IncNeedToWinBalls;
    }

    private void OnDisable()
    {
        scr_CannonShooting.IsShooting -= IncActualBalls;
        scr_BallEnteredTrigger.OnTriggered -= IncNeedToWinBalls;
    }

    private void Start()
    {
        BallsIntoTrigger = 0;
        ActualBalls = _levelSettings.MaxBalls;
        BallsNeedToWin = _levelSettings.NeedBallsToWin;
    }

    private void IncNeedToWinBalls()
    {
        BallsIntoTrigger++;
        scr_ResetNeedToWinBalls.ResetText(BallsIntoTrigger);
    }

    private void IncActualBalls()
    {
        ActualBalls--;
        scr_ResetActuallBallsText.ResetText();
    }
}