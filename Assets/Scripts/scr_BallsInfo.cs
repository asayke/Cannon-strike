using UnityEngine;

public class scr_BallsInfo : MonoBehaviour
{
    [SerializeField] private LevelSettings _levelSettings;
    public static int MaxBalls;
    public static int ActualBalls;
    public static int BallsNeedToWin;

    private void OnEnable()
    {
        scr_BallEnteredTrigger.OnTriggered += IncActualBalls;
    }

    private void OnDisable()
    {
        scr_BallEnteredTrigger.OnTriggered -= IncActualBalls;
    }

    private void Start()
    {
        MaxBalls = _levelSettings.MaxBalls;
        ActualBalls = _levelSettings.MaxBalls;
        BallsNeedToWin = _levelSettings.NeedBallsToWin;
    }

    private void IncActualBalls()
    {
        ActualBalls--;
        scr_ResetActuallBallsText.ResetText();
    }
}