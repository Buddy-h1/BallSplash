using UnityEngine;

public class BallExplosion : MonoBehaviour
{

    //Брызги при взрыве
    public GameObject[] splashEffectsSprites;
    public GameObject splashEffect;

    public void SplashEffect(Vector2 position)
    {
        Instantiate(splashEffect, position, Quaternion.identity);
        Instantiate(splashEffectsSprites[Random.Range(0, splashEffectsSprites.Length)], position, Quaternion.identity);
    }

}
