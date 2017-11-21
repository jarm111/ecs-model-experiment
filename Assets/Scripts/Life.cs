using UnityEngine;

public class Life : MonoBehaviour {

    [SerializeField]
    private float health = 1;

    public void ReduceHealth(float amount)
    {
        health = (health <= amount) ? health = 0 : health - amount;

        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
