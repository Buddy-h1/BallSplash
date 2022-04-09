using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{
    public void PlayNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
        GameController.levelComplete = false;
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        GameController.levelComplete = false;
        BallCollision.countSplashNull = false;
    }

    public void OpenLevels()
    {
        SceneManager.LoadScene("Levels");
        Time.timeScale = 1;
        GameController.levelComplete = false;
    }
}
