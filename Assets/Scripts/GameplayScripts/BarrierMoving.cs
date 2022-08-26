using DG.Tweening;
using UnityEngine;

public class BarrierMoving : MonoBehaviour
{
    [SerializeField] private float _intervalTime;
    [SerializeField] private float _xOffset;

    private void Start()
    {
        Vector3 offsetPosition =
            new Vector3(transform.position.x + _xOffset, transform.position.y, transform.position.z);

        Vector3 newOffsetPostiont =
            new Vector3(transform.position.x - _xOffset, transform.position.y, transform.position.z);

        transform.DOMove(offsetPosition, _intervalTime).OnComplete(() =>
            transform.DOMove(newOffsetPostiont, _intervalTime).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear));
    }
}