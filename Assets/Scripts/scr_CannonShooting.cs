using Unity.Mathematics;
using UnityEngine;

public class scr_CannonShooting : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _timeBetweenClicks;
    [SerializeField] private Transform _barrel;
    private float _timer;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _timer += Time.deltaTime;

            if (_timer >= _timeBetweenClicks)
            {
                _timer = 0;
                Instantiate(_bulletPrefab, _barrel.transform.position, quaternion.identity);
            }
        }
    }
}