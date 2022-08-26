using System;
using UnityEngine;

public class CannonShooting : MonoBehaviour
{
    [SerializeField] private float _timeBetweenClicks;
    private float _timer;
    public static Action IsShooting;
    public static bool CouldShoot;

    private void Start() => CouldShoot = true;

    private void Update()
    {
        if (Input.GetMouseButton(0) && CouldShoot)
        {
            _timer += Time.deltaTime;

            if (_timer >= _timeBetweenClicks)
            {
                IsShooting?.Invoke();
                BallSpawner.Spawn();
                _timer = 0;
            }
        }
    }
}