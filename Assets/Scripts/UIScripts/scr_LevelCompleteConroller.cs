using UnityEngine;

public class scr_LevelCompleteConroller : MonoBehaviour
{
    [SerializeField] private GameObject UiLevelCompleteObject;
    
    private void OnEnable()
    {
        scr_GameChecker.OnWinned += EnableLeveleCompleteUI;
    }

    private void OnDisable()
    {
        scr_GameChecker.OnWinned -= EnableLeveleCompleteUI;
    }

    private void Start()
    {
        UiLevelCompleteObject.SetActive(false);
    }

    private void EnableLeveleCompleteUI() => UiLevelCompleteObject.SetActive(true);
}