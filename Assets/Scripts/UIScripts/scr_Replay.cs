using UnityEngine;
using UnityEngine.EventSystems;

public class scr_Replay : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData) => scr_ScreenFade.ScreenReset();
}