using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject morality;
    public GameObject indication;
    public GameObject countSplash;

    public GameObject restartButton;
    public GameObject levelsButton;

    void Start()
    {
        countSplash.SetActive(false);
        Time.timeScale = 0;
    }

    private bool pause = false;
    public static bool levelComplete = false;

    void Update()
    {
        //if (Input.GetMouseButtonDown(0) && BallCollision.countSplash != -1 && levelComplete == false)
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) && BallCollision.countSplashNull != true && levelComplete == false && pause == false)
        {
            morality.SetActive(false);
            indication.SetActive(false);
            countSplash.SetActive(true);
            Time.timeScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && pause == false && Time.timeScale == 1)
        {
            restartButton.SetActive(true);
            levelsButton.SetActive(true);
            pause = true;
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pause == true)
        {
            restartButton.SetActive(false);
            levelsButton.SetActive(false);
            pause = false;
            Time.timeScale = 1;
        }

    }
}
