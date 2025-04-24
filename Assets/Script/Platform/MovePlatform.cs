using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    [SerializeField] private float _movespeed = 5f;
    
     private float _leftBorder;
     private float _rightBorder;
     private float _platformHalf;

    private void Start()
    {
        ScreenBorders();
    }

    private void Update()
    {
        PlatformMovement();
    }
    
    private void ScreenBorders()
    {
        _platformHalf = transform.position.x / 2;
        
        float screenAspect = Screen.width / (float)Screen.height;
        float cameraHeight = Camera.main.orthographicSize;
        float cameraWidth = cameraHeight * screenAspect;

        _leftBorder = -cameraWidth + _platformHalf;
        _rightBorder = cameraWidth - _platformHalf;
    }

    private void PlatformMovement()
    {
        float moveInput = Input.GetAxis("Horizontal");
        float newXPos = transform.position.x + moveInput * _movespeed * Time.deltaTime;
        newXPos = Mathf.Clamp(newXPos, _leftBorder + transform.localScale.x / 2f, _rightBorder - transform.localScale.x / 2f);
        transform.position = new Vector3(newXPos, transform.position.y, transform.position.z);
    }

   
}
