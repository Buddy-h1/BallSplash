using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static int countUnlockedlevel = 1;

    public Sprite unlockedIcon;
    public Sprite lockedIcon;

    void Start()
    {
        countUnlockedlevel = PlayerPrefs.GetInt("COUNT_UNLOCKED_LEVELS");
        for (int i = 0; i < transform.childCount; i++)
        {
            if (i < countUnlockedlevel)
            {
                transform.GetChild(i).GetComponent<Image>().sprite = unlockedIcon;
                transform.GetChild(i).GetComponent<Button>().interactable = true;
            }
            else
            {
                transform.GetChild(i).GetComponent<Image>().sprite = lockedIcon;
                transform.GetChild(i).GetComponent<Button>().interactable = false;
            }
        }
    }

}
