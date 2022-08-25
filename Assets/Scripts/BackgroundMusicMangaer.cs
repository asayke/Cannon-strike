using UnityEngine;

public class BackgroundMusicMangaer : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}