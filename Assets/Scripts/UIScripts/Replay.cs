using UnityEngine;
using UnityEngine.EventSystems;

public class Replay : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData) => ScreenFade.ScreenReset();
}