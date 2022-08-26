using TMPro;
using UnityEngine;

public class ResetActuallBallsText : MonoBehaviour
{
    private static TextMeshProUGUI _actualBallText;

    private void Awake()
    {
        _actualBallText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        _actualBallText.SetText($"{BallsInfo.ActualBalls}");
    }

    public static void ResetText() => _actualBallText.SetText($"{BallsInfo.ActualBalls}");
}