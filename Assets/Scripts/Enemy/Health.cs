using UnityEngine;


public class Health : MonoBehaviour
{
    [SerializeField] private float _health;

    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _health;
    }
    public void ApplyDamage(float damage)
    {
        _currentHealth -= damage;

        if (_currentHealth < 0)
        {
            Die();
        }
    }

    private void Die()
    {

    }
}

