using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelStart : MonoBehaviour
{
    public int numLevel;


    public void BeginLevel()
    {        
        SceneManager.LoadScene(numLevel);
        Time.timeScale = 1;
    }
}
