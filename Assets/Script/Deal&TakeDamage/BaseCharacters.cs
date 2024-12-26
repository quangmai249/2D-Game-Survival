using UnityEngine;

public class BaseCharacters : MonoBehaviour
{
    protected float baseDamage;
    protected float maxHealth;
    protected float currentHealth;
    void Start()
    {
        this. currentHealth = this.maxHealth;
    }
    protected virtual void DealDamage(BaseCharacters obj)
    {
        if (obj != null)
        {
            obj.TakeDamage(this.baseDamage);
        }
    }
    protected virtual void TakeDamage(float amount)
    {
        this.currentHealth -= amount;
        if (this.currentHealth < 0) Die();
    }
    protected virtual void Heal(float amount)
    {
        this.currentHealth += amount;
        if(this.currentHealth > this.maxHealth) this.currentHealth = this.maxHealth;
    }
    protected virtual void Die()
    {

    }
}
