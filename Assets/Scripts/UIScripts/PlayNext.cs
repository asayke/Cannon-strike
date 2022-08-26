using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayNext : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        if (SceneManager.GetActiveScene().buildIndex + 1 <= 3)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}