using System;
using Unity.Mathematics;
using UnityEngine;

public class scr_CannonShooting : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _timeBetweenClicks;
    [SerializeField] private Transform _barrel;
    private float _timer;
    public static Action IsShooting;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _timer += Time.deltaTime;
            
            if (_timer >= _timeBetweenClicks)
            {
                IsShooting?.Invoke();
                _timer = 0;
                Instantiate(_bulletPrefab, _barrel.transform.position, quaternion.identity);
            }
        }
    }
}