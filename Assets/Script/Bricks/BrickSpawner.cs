using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    [SerializeField] private BrickSettings _settings;
    [SerializeField] private GameObject _brickPrefab;
    [SerializeField] private Vector2 _spacing;
    

    private void Start()
    {
        SpawnBricks();
    }

    private void SpawnBricks()
    {
        var coordX = 0f;
        var coordY = 0f;
        
        for (int y = 0; y < _settings.rows; y++)
        {
            for (int x = 0; x < _settings.columns; x++)
            {
                GameObject brick = Instantiate(_brickPrefab, transform);
                brick.transform.localPosition = new Vector3(coordX, coordY, 0);
                if (brick.TryGetComponent(out Renderer renderer))
                {
                    renderer.material.color = _settings.rowColors[y];
                }
                coordX += _spacing.x;
            }
            coordY += _spacing.y;
            coordX = 0f;
        }
    }
}