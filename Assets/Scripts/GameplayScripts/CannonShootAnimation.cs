using DG.Tweening;
using UnityEngine;

public class CannonShootAnimation : MonoBehaviour
{
    [SerializeField] private float _toOffsetDuration;
    [SerializeField] private float _backToOriginalDuration;
    [SerializeField] private float _shootOffset;
    private Vector2 _offsetPostion;
    private Vector3 _originalPostion;

    private void OnEnable()
    {
        CannonShooting.IsShooting += ShootAnimationPlay;
    }

    private void OnDisable()
    {
        CannonShooting.IsShooting -= ShootAnimationPlay;
    }

    private void Start()
    {
        _originalPostion = transform.position;
        _offsetPostion = new Vector2(transform.position.x, transform.position.y + _shootOffset);
    }

    private void ShootAnimationPlay() =>
        transform.DOMove(_offsetPostion, _toOffsetDuration).SetEase(Ease.Linear).OnComplete(() =>
            transform.DOMove(_originalPostion, _backToOriginalDuration).SetEase(Ease.Linear));
}