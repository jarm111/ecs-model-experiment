using UnityEngine;

public class CircularPatrolMovement : MonoBehaviour {

    [SerializeField]
    private float radius = 1;
    [SerializeField]
    private float speed = 3;
    private float timer;
    private float angle;
    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        PatrolInCircle();
    }

    private void PatrolInCircle()
    {
        timer += Time.deltaTime;
        angle = timer * speed;
        rb2d.velocity = new Vector2((Mathf.Sin(angle) * radius),
            (Mathf.Cos(angle) * radius));
    }
}
