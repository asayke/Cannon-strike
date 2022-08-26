using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _spawnPoint;
    private static GameObject _bulletPrefabS;
    private static Transform _spawnPointS;

    private void Start()
    {
        _bulletPrefabS = _bulletPrefab;
        _spawnPointS = _spawnPoint;
    }

    public static void Spawn() => Instantiate(_bulletPrefabS, _spawnPointS.position, Quaternion.identity);
}