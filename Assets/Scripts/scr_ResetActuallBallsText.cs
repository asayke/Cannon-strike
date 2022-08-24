using System;
using TMPro;
using UnityEngine;

public class scr_ResetActuallBallsText : MonoBehaviour
{
    private static TextMeshProUGUI _actualBallText;

    private void Awake()
    {
        _actualBallText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        _actualBallText.SetText($"{scr_BallsInfo.ActualBalls}");
    }

    public static void ResetText() => _actualBallText.SetText($"{scr_BallsInfo.ActualBalls}");
}