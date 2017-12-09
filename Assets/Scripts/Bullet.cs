using UnityEngine;

public class Bullet : MonoBehaviour {

    [SerializeField]
    private float speed = 3;
    [SerializeField]
    private float lifetime = 2;
    [SerializeField]
    private float damage = 1;
    private Vector2 direction;
    private Rigidbody2D rb2d;

    public Vector2 Direction
    {
        set
        {
            direction = value;
            direction.Normalize();
        }
    }

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifetime);
    }

    private void Update()
    {
        rb2d.velocity = direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var life = collision.GetComponent<Life>();

        if (life != null)
        {
            life.ReduceHealth(damage);
        }

        Destroy(gameObject);
    }
}
