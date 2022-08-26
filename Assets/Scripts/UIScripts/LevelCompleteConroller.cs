using UnityEngine;

public class LevelCompleteConroller : MonoBehaviour
{
    [SerializeField] private GameObject _uiLevelCompleteObject;
    
    private void OnEnable()
    {
        GameChecker.OnWinned += EnableLeveleCompleteUI;
    }

    private void OnDisable()
    {
        GameChecker.OnWinned -= EnableLeveleCompleteUI;
    }

    private void Start()
    {
        _uiLevelCompleteObject.SetActive(false);
    }

    private void EnableLeveleCompleteUI() => _uiLevelCompleteObject.SetActive(true);
}