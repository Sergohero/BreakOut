using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayManager : MonoBehaviour
{
    public static int BrickCount; 

    void Start()
    {
        BrickCount = GameObject.FindGameObjectsWithTag("Brick").Length;
    }
    
    public static void DecreaseBrickCount()
    {
        BrickCount--;
        if (BrickCount <= 0)
        {
            EndGame();
        }
    }

    private static void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
