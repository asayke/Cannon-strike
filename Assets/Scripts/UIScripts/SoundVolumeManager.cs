using UnityEngine;
using UnityEngine.EventSystems;

public class SoundVolumeManager : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData) => AudioListener.pause = !AudioListener.pause;
}