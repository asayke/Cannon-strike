using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class scr_BackToMenu : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData) => SceneManager.LoadScene("Menu");
}