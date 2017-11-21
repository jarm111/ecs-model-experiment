using UnityEngine;

public class Life : MonoBehaviour {

    [SerializeField]
    private float maxHealth = 1;
    public float MaxHealth
    {
        get
        {
            return maxHealth;
        }
    }

    private float currentHealth = 1;
    public float CurrentHealth
    {
        get
        {
            return currentHealth;
        }
    }
    
    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void ReduceHealth(float amount)
    {
        currentHealth = (currentHealth <= amount) ? currentHealth = 0 : currentHealth - amount;

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
