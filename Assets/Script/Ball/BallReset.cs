using System;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    private Vector3 _spawnPointBall; 
    private Rigidbody _rb;
    private MoveBall _moveBall;
    
    public event Action OnBallReset;
    private void Start()
    {
        _spawnPointBall = transform.position;
        _rb = GetComponent<Rigidbody>();
        _moveBall = gameObject.GetComponent<MoveBall>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            BallReseter();
        }
    }

    private void BallReseter()
    {
        
        transform.position = _spawnPointBall;
        _moveBall._isLaunched = false;
        _rb.velocity = Vector3.zero;
        _rb.angularVelocity = Vector3.zero;
        
        OnBallReset?.Invoke();
    }
}

