using UnityEngine;

public sealed class SpawnerPlatform : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    
    private float _distance = 1f;
    
    private void Start()
    {
        SpawnPlatform();
    }
    private void SpawnPlatform()
    {
        Instantiate(_cubePrefab, transform);
        
    }
}
