using UnityEngine;
using UnityEngine.UI;

public class LevelReset : MonoBehaviour
{

    public GameObject levelsButtons;
    public Sprite unlockedIcon;
    public Sprite lockedIcon;

    public void RestartCountLevel()
    {
        PlayerPrefs.SetInt("COUNT_UNLOCKED_LEVELS", 1);
        PlayerPrefs.Save();

        LevelManager.countUnlockedlevel = 1;
        for (int i = 0; i < levelsButtons.transform.childCount; i++)
        {
            if (i < LevelManager.countUnlockedlevel)
            {
                levelsButtons.transform.GetChild(i).GetComponent<Image>().sprite = unlockedIcon;
                levelsButtons.transform.GetChild(i).GetComponent<Button>().interactable = true;
            }
            else
            {
                levelsButtons.transform.GetChild(i).GetComponent<Image>().sprite = lockedIcon;
                levelsButtons.transform.GetChild(i).GetComponent<Button>().interactable = false;
            }
        }
    }
}
