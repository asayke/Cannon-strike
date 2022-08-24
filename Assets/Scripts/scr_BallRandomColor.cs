using UnityEngine;
using Random = UnityEngine.Random;

public class scr_BallRandomColor : MonoBehaviour
{
    private SpriteRenderer _ballRenderer;

    private void Awake()
    {
        _ballRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _ballRenderer.color = new Color(Random.value, Random.value, Random.value, 1);
    }
}