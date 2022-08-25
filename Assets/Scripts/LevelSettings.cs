using UnityEngine;

[CreateAssetMenu(fileName = "Settings", menuName = "ScriptableObjects", order = 1)]
public class LevelSettings : ScriptableObject
{
    public int MaxBalls;
    public int NeedBallsToWin;
}