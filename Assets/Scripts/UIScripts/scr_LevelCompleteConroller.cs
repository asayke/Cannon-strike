using UnityEngine;

public class scr_LevelCompleteConroller : MonoBehaviour
{
    [SerializeField] private GameObject _uiLevelCompleteObject;
    
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
        _uiLevelCompleteObject.SetActive(false);
    }

    private void EnableLeveleCompleteUI() => _uiLevelCompleteObject.SetActive(true);
}