using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_ScreenFade : MonoBehaviour
{
    [SerializeField] private float _fadeDuration;
    [SerializeField] private float _outFadeDuration;
    private static float _fadeDurationS;
    private static float _outFadeDurationS;
    private static SpriteRenderer _screenSpriteRenderer;

    private void Awake()
    {
        _fadeDurationS = _fadeDuration;
        _outFadeDurationS = _outFadeDuration;
        _screenSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    public static void ScreenReset()
    {
        _screenSpriteRenderer.DOFade(255, _fadeDurationS).SetEase(Ease.Linear)
            .OnComplete(() =>
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                _screenSpriteRenderer.DOFade(0, _outFadeDurationS).SetEase(Ease.Linear);
            });
    }
}