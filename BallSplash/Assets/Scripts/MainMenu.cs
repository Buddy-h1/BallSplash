using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        Screen.SetResolution(1280, 720, false);
    }
    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(PlayerPrefs.GetInt("COUNT_UNLOCKED_LEVELS"));
    }

    public void OpenLevels()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Levels");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
