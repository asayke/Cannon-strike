using UnityEngine;

public class scr_CannonShootSound : MonoBehaviour
{
    [SerializeField] private AudioClip _shootClip;
    private static AudioSource _audioSource;
    private static float _volumeScale = 0.1f;

    private void OnEnable()
    {
        scr_CannonShooting.IsShooting += PlayShootSound;
    }

    private void OnDisable()
    {
        scr_CannonShooting.IsShooting += PlayShootSound;
    }

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void PlayShootSound()
    {
        _audioSource.PlayOneShot(_shootClip, _volumeScale);
    }
}