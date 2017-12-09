using UnityEngine;

public class Life : MonoBehaviour {

    [SerializeField]
    private float maxHealth = 1;
    private float currentHealth = 1;
    private Subject subject = new Subject();

    public float MaxHealth
    {
        get
        {
            return maxHealth;
        }
    }

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
        subject.AddObserver(TeamCount.Instance);
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
        subject.Notify(gameObject);
        Destroy(gameObject);
    }

    public void IncreaseHealth(float amount)
    {
        currentHealth += Mathf.Clamp(amount, 0, MaxHealth - currentHealth);
    }
}
