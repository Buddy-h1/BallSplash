using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{
    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }
}
