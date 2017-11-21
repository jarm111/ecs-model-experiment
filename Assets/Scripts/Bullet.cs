using UnityEngine;

public class Bullet : MonoBehaviour {

    [SerializeField]
    private float speed = 3;
    [SerializeField]
    private float lifetime = 2;
    [SerializeField]
    private float damage = 1;

    private Vector2 direction;
    public Vector2 Direction
    {
        set
        {
            direction = value;
            direction.Normalize();
        }
    }

    private Rigidbody2D rb2d;

    private void Start()
    {
        //direction = new Vector3(speed, 0, 0);
        rb2d = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifetime);
    }

    private void Update()
    {
        rb2d.velocity = direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Life>().ReduceHealth(damage);
    }
}
