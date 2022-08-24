using System;
using UnityEngine;

public class scr_BallEnteredTrigger : MonoBehaviour
{
    [SerializeField] private LayerMask _ballLayerMask;
    public static Action OnTriggered;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.IsInLayerMask(_ballLayerMask))
        {
            OnTriggered?.Invoke();
        }
    }
}