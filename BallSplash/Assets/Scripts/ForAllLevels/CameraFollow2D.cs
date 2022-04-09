using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{

    public Transform playerTransform;
    public float movingSpeed = 3;

    private void Update()
    {
        if (this.playerTransform)
        {
            Vector3 target = new Vector3()
            {
                x = this.playerTransform.position.x + 5,
                y = 0,
                z = this.playerTransform.position.z - 10
            };

            Vector3 pos = Vector3.Lerp(this.transform.position, target, this.movingSpeed * Time.deltaTime);
            this.transform.position = pos;
        }
    }

}
