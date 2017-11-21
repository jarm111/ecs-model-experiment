using UnityEngine;

public class Shield : MonoBehaviour {

    [SerializeField]
    private float shieldStrenght = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        shieldStrenght--;

        if (shieldStrenght <= 0)
        {
            Destroy(gameObject);
        }
    }
}
