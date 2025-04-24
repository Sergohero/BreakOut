using TMPro;
using UnityEngine;

public class BrickDestroyer : MonoBehaviour
{
    [SerializeField] private int _maxHits = 3;
    [SerializeField] private TextMeshProUGUI _textScore;
    
    private int _score;
    private int _currentHits = 0;

    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            _currentHits++;
            if (_currentHits >= _maxHits)
            {
                Destroy(gameObject);
                GameplayManager.DecreaseBrickCount();
                //ScoreUpdate();
            }
        }
    }
    // private void ScoreUpdate()
    // {
    //     _score++;
    //     TextToString();
    // }
    // private void TextToString()
    // {
    //     _textScore.text = _score.ToString();
    // }
    
    
}