using UnityEngine;

public class CircularPatrolMovement : MonoBehaviour {

    [SerializeField]
    private float radius = 1;
    [SerializeField]
    private float speed = 3;

    private float timer;
    private float angle;
    private float centerX;
    private float centerY;
    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        centerX = transform.position.x;
        centerY = transform.position.x;
    }

    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        angle = timer * speed;
        rb2d.velocity = new Vector2((centerX + Mathf.Sin(angle) * radius), 
            (centerY + Mathf.Cos(angle) * radius));
    }
}
