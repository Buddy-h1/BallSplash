using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallCollision : MonoBehaviour
{
    void Start()
    {
        splashText.text = "splash: " + countSplash;
        levelComplete.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        nextLevelButton.gameObject.SetActive(false);
        levelsButton.gameObject.SetActive(false);
    }

    //Обработка сценария при столкновении
    public Button restartButton;
    public Button nextLevelButton;
    public Button levelsButton;

    public Text splashText;
    public Text levelComplete;
    public static bool countSplashNull = false;
    public int countSplash;
    public BallExplosion ballExplosion;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            LevelComplete();
            GameController.levelComplete = true;
            levelComplete.gameObject.SetActive(true);
            splashText.gameObject.SetActive(false);
            return;
        }

        countSplash--;
        if (countSplash == -1)
        {
            restartButton.gameObject.SetActive(true);
            levelsButton.gameObject.SetActive(true);
            splashText.text = "splash: none";
            countSplashNull = true;
            Time.timeScale = 0;
        }
        else
        {
            splashText.text = "splash: " + countSplash;
            ballExplosion.SplashEffect(transform.position);
            transform.position = new Vector3(-7, 0, 0);
        }
    }

    private void LevelComplete()
    {
        Time.timeScale = 0;
        nextLevelButton.gameObject.SetActive(true);
        levelsButton.gameObject.SetActive(true);
        Debug.Log(LevelManager.countUnlockedlevel);
        if (SceneManager.GetActiveScene().buildIndex == LevelManager.countUnlockedlevel)
        {
            LevelManager.countUnlockedlevel++;
            PlayerPrefs.SetInt("COUNT_UNLOCKED_LEVELS", LevelManager.countUnlockedlevel);
            PlayerPrefs.Save();
        }
    }
}
