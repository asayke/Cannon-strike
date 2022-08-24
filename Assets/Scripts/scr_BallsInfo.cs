using UnityEngine;

public class scr_BallsInfo : MonoBehaviour
{
    [SerializeField] private LevelSettings _levelSettings;
    public static int ActualBalls;
    public static int BallsNeedToWin;
    private int _ballsIntoTrigger;

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
        ActualBalls = _levelSettings.MaxBalls;
        BallsNeedToWin = _levelSettings.NeedBallsToWin;
    }

    private void IncNeedToWinBalls()
    {
        _ballsIntoTrigger++;
        scr_ResetNeedToWinBalls.ResetText(_ballsIntoTrigger);
    }

    private void IncActualBalls()
    {
        ActualBalls--;
        scr_ResetActuallBallsText.ResetText();
    }
}