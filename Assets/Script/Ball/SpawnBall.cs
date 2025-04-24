using UnityEngine;

public sealed class SpawnBall : MonoBehaviour
{
    [SerializeField] private GameObject _ballPrefab;
    private void Start()
    {
        SpawnBallOnPlatform();
    }
    public void SpawnBallOnPlatform()
    {
        Instantiate(_ballPrefab, transform);
    }
}

