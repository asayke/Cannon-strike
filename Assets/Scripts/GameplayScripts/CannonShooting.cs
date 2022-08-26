using System;
using UnityEngine;

public class CannonShooting : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _timeBetweenClicks;
    [SerializeField] private Transform _barrel;
    private float _timer;
    public static Action IsShooting;
    public static bool CouldShoot;

    private void Start()
    {
        CouldShoot = true;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && CouldShoot)
        {
            _timer += Time.deltaTime;

            if (_timer >= _timeBetweenClicks)
            {
                IsShooting?.Invoke();
                _timer = 0;
                Instantiate(_bulletPrefab, _barrel.transform.position, Quaternion.identity);
            }
        }
    }
}