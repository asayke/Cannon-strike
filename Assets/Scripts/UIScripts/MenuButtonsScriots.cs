using UnityEngine;

public class MenuButtonsScriots : MonoBehaviour
{
    [SerializeField] private GameObject _chooseLevelObject;
    [SerializeField] private GameObject _tittleObject;

    private void Start()
    {
        _chooseLevelObject.SetActive(false);
        _tittleObject.SetActive(true);
    }

    public void ReturnToTitle()
    {
        _chooseLevelObject.SetActive(false);
        _tittleObject.SetActive(true);
    }

    public void GoToChooseLevel()
    {
        _chooseLevelObject.SetActive(true);
        _tittleObject.SetActive(false);
    }

    public void ResetVolueValue() => AudioListener.pause = !AudioListener.pause;
}