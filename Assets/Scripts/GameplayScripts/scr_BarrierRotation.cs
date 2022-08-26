using DG.Tweening;
using UnityEngine;

public class scr_BarrierRotation : MonoBehaviour
{
    [SerializeField] private float _rotatingTime;

    private void Start()
    {
        Vector3 rotatingVector = new Vector3(0, 0, 360);

        transform.DORotate(rotatingVector, _rotatingTime).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
    }
}