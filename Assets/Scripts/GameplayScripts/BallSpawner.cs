using UnityEngine;

public class BallSpawner : MonoBehaviour, ISpawner
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _spawnPoint;

    private void OnEnable() => CannonShooting.IsShooting += Spawn;

    private void OnDisable() => CannonShooting.IsShooting -= Spawn;

    public void Spawn() => Instantiate(_bulletPrefab, _spawnPoint.position, Quaternion.identity);
}