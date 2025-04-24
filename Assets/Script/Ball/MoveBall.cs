using UnityEngine;

public class MoveBall : MonoBehaviour
{
    [SerializeField] private float _speedUp = 1f;
    private Rigidbody _rb;
    public bool _isLaunched = false;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        PushBall();
    }

    private void PushBall()
    {
        if (Input.GetKey(KeyCode.Space) && !_isLaunched)
        {
             _isLaunched = true;
             _rb.WakeUp();
            _rb.AddForce(Vector3.up * _speedUp, ForceMode.Impulse);
        }
    }
}
