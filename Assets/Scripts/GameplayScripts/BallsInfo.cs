using UnityEngine;

public class BallsInfo : MonoBehaviour
{
    [SerializeField] private LevelSettings _levelSettings;
    public static int ActualBalls;
    public static int BallsNeedToWin;
    public static int BallsIntoTrigger;

    private void Start()
    {
        BallsIntoTrigger = 0;
        ActualBalls = _levelSettings.MaxBalls;
        BallsNeedToWin = _levelSettings.NeedBallsToWin;
    }
}