using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelStart : MonoBehaviour
{
    public int numLevel;


    public void BeginLevel()
    {
        Time.timeScale = 1;
        BallCollision.countSplashNull = false;
        SceneManager.LoadScene(numLevel);
    }
}
