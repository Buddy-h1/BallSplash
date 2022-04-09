using UnityEngine;

public class BallMovement: MonoBehaviour
{

    public float impulseStrength = 8;
    public float speedMoveRight = 3;
    public Rigidbody2D rigidBody;

    void Update()
    {
        transform.position += Vector3.right * speedMoveRight * Time.deltaTime;
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)))
        {
            rigidBody.velocity = Vector2.up * impulseStrength;
        }
    }

}
