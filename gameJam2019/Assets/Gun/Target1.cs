
using UnityEngine;

public class Target1 : MonoBehaviour
{
    public float health = 50.0f;
    public Health health1;

    public void TakeDamage(float amount)
    {
        health -= amount;
        health1.ModifyHealth(amount);
        if (health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }


}
