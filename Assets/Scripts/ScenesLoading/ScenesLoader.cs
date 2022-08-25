using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesLoader : MonoBehaviour
{
    public void LoadFirstLevel() => SceneManager.LoadScene("Level1");

    public void LoadSecondLevel() => SceneManager.LoadScene("Level2");

    public void LoadThirdLevel() => SceneManager.LoadScene("Level3");
}