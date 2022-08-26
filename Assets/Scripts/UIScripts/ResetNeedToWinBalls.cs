using System.Collections;
using TMPro;
using UnityEngine;

public class ResetNeedToWinBalls : MonoBehaviour
{
    private static TextMeshProUGUI _needToWinBallText;

    private void Awake()
    {
        _needToWinBallText = GetComponent<TextMeshProUGUI>();
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(Mathf.Epsilon);
        _needToWinBallText.SetText($"0/{BallsInfo.BallsNeedToWin}");
    }

    public static void ResetText(int ballIntoTrigger) =>
        _needToWinBallText.SetText($"{ballIntoTrigger}/{BallsInfo.BallsNeedToWin}");
}