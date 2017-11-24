using UnityEngine;

public class Life : Subject {

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
        AddObserver(TeamCount.Instance);
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
        Notify(gameObject);
        Destroy(gameObject);
    }

    public void IncreaseHealth(float amount)
    {
        currentHealth += Mathf.Clamp(amount, 0, MaxHealth - currentHealth);
    }
}
