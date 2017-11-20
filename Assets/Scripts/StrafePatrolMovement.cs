using UnityEngine;

public class StrafePatrolMovement : MonoBehaviour {

    [SerializeField]
    private float speed = 1;
    [SerializeField]
    private float minY = 0;
    [SerializeField]
    private float maxY = 10;

    private Rigidbody2D rb2d;


    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (transform.position.y > maxY && speed > 0)
        {
            speed = -speed;
        }
        else if (transform.position.y < minY && speed < 0)
        {
            speed = -speed;
        }

        rb2d.velocity = new Vector2(0, speed);
    }

    private void FixedUpdate()
    {
        //rb2d.velocity = new Vector2(0, speed);
    }
}
